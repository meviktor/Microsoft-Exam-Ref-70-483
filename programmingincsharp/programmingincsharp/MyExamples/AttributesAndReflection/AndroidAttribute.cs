namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    public class AndroidAttribute : MobileAttribute
    {
        public AndroidAttribute() : base(OperatingSystem.Android) { }
    }
}