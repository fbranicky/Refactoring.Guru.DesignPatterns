namespace Refactoring.Guru.DesignPatterns.AbstractFactory
{
    public class Telecaster : IElectricGuitar
    {
        public int GetPickups()
        {
            return 2;
        }
    }
}
