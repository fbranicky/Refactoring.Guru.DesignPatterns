namespace Refactoring.Guru.DesignPatterns.AbstractFactory
{
    public class CountryFactory : IGenreFactory
    {
        public IAmplifier CreateAmplifier()
        {
            return new HotRodDeluxe();
        }

        public IElectricGuitar CreateGuitar()
        {
            return new Telecaster();
        }
    }
}
