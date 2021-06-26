namespace Refactoring.Guru.DesignPatterns.AbstractFactory
{
    public interface IGenreFactory
    {
        IElectricGuitar CreateGuitar();
        IAmplifier CreateAmplifier();
    }
}
