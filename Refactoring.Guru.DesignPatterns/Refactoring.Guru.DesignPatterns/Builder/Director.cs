namespace Refactoring.Guru.DesignPatterns.Builder
{
    /// <summary>
    /// A Builder allows for step by step construction of complex objects. This is often done by refactoring
    /// large constructors of their output objects to methods in the builder.
    /// A Director defines the order in which the Builder executes the steps.
    /// The final result is retrieved from the Builder.
    /// </summary>

    public class Director
    {
        private GuitarBuilder _guitarBuilder;

        public GuitarBuilder GuitarBuilder { set { _guitarBuilder = value; } }

        public void ConstructTelecaster()
        {
            _guitarBuilder.Reset();
            _guitarBuilder.SetName("Telecaster");
            _guitarBuilder.SetBody("alder");
            _guitarBuilder.SetNeck("maple");
            _guitarBuilder.SetElectronics("2 pickups");
            _guitarBuilder.SetStrings("ernie ball");
        }

        public void ConstructTroublemaker()
        {
            _guitarBuilder.Reset();
            _guitarBuilder.SetName("Troublemaker");
            _guitarBuilder.SetBody("mahogany");
            _guitarBuilder.SetNeck("mahogany");
            _guitarBuilder.SetElectronics("3 pickups");
            _guitarBuilder.SetStrings("fender");
        }
    }
}
