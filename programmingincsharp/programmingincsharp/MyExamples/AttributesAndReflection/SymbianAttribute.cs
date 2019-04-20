namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    public class SymbianAttribute : MobileAttribute
    {
        public SymbianAttribute() : base(OperatingSystem.Symbian) { }
    }
}