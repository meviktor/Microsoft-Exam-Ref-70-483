using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace programmingincsharp.MyExamples
{
    public static class ExpandoObjectExample
    {
        public static void Main()
        {
            CreateAndAdd();
            PassingAsParameter();
            EnumeratingAndDeleting();
            PropertyChanges();
        }

        private static void CreateAndAdd()
        {
            //CREATING
            dynamic sampleObject = new ExpandoObject();

            //ADDING PROPERTY
            sampleObject.test = "Dynamic Property";
            Console.WriteLine(sampleObject.test);
            Console.WriteLine(sampleObject.test.GetType());
            // This code example produces the following output:
            // Dynamic Property
            // System.String

            //ADDING METHODS (AS LAMBDA)
            sampleObject.number = 10;
            sampleObject.Increment = (Action)(() => { sampleObject.number++; });
            // Before calling the Increment method.
            Console.WriteLine(sampleObject.number);
            sampleObject.Increment();
            // After calling the Increment method.
            Console.WriteLine(sampleObject.number);
            // This code example produces the following output:
            // 10
            // 11

            //ADDING AN EVENT
            // Create a new event and initialize it with null.  
            sampleObject.sampleEvent = null;
            // Add an event handler.  
            sampleObject.sampleEvent += new EventHandler(SampleHandler);
            // Raise an event for testing purposes.  
            sampleObject.sampleEvent(sampleObject, new EventArgs());
        }

        private static void SampleHandler(object sender, EventArgs e)
        {
            Console.WriteLine("SampleHandler for {0} event", sender);
        }

        private static void PassingAsParameter()
        {
            dynamic employee, manager;

            employee = new ExpandoObject();
            employee.Name = "John Smith";
            employee.Age = 33;

            manager = new ExpandoObject();
            manager.Name = "Allison Brown";
            manager.Age = 42;
            manager.TeamSize = 10;

            WritePerson(manager);
            WritePerson(employee);
            // This code example produces the following output:
            // John Smith is 33 years old.
            // Allison Brown is 42 years old.
        }

        private static void WritePerson(dynamic person)
        {
            Console.WriteLine("{0} is {1} years old.",
                              person.Name, person.Age);
            // The following statement causes an exception
            // if you pass the employee object.
            // Console.WriteLine("Manages {0} people", person.TeamSize);
        }

        private static void EnumeratingAndDeleting()
        {
            dynamic employee = new ExpandoObject();
            employee.Name = "John Smith";
            employee.Age = 33;

            foreach (var property in (IDictionary<String, Object>)employee)
            {
                Console.WriteLine(property.Key + ": " + property.Value);
            }
            // This code example produces the following output:
            // Name: John Smith
            // Age: 33

            employee.Name = "John Smith";
            ((IDictionary<String, Object>)employee).Remove("Name");
        }

        private static void PropertyChanges()
        {
            dynamic employee = new ExpandoObject();
            ((INotifyPropertyChanged)employee).PropertyChanged +=
                new PropertyChangedEventHandler(HandlePropertyChanges);
            employee.Name = "John Smith";
        }

        private static void HandlePropertyChanges(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("{0} has changed.", e.PropertyName);
        }
    }
}