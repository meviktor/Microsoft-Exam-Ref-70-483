namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    public class MobileAttribute : AppTargetAttribute
    {
        public OperatingSystem Os { get; set; }

        public MobileAttribute(OperatingSystem os) : base("Mobile")
        {
            Os = os;
        }
    }

    public enum OperatingSystem { Android, iOS, WindowsPhone, Symbian };
}