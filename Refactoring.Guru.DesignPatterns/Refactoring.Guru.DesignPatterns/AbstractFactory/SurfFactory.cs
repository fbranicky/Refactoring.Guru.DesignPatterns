namespace Refactoring.Guru.DesignPatterns.AbstractFactory
{
    public class SurfFactory : IGenreFactory
    {
        public IAmplifier CreateAmplifier()
        {
            return new TwinReverb();
        }

        public IElectricGuitar CreateGuitar()
        {
            return new Jazzmaster();
        }
    }
}
