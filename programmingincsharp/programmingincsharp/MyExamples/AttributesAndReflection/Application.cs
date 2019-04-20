using System;

namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    [Symbian]
    [Android]
    [Mobile(OperatingSystem.iOS), Mobile(OperatingSystem.WindowsPhone)]
    [Desktop]
    public class Application
    {
        private double _avgStars;
        public string Name { get; set; }

        public string LatestVersion { get; set; }

        public double AvgStars
        {
            get
            {
                return _avgStars;
            }
            set
            {
                if (value > 0.0 && value <= 5.0)
                {
                    _avgStars = value;
                }
                else throw new ArgumentException("Value of average stars must be between 0.0 and 5.0!");
            }
        }

        public void ShowAppInfo(string askedFrom)
        {
            Console.WriteLine(
                "This information was requested by " + askedFrom + "\n" +
                "AppName: " + Name + "\n" +
                "LatestVersion: " + LatestVersion + "\n" +
                "AvgStars: " + AvgStars
            );
        }
    }
}