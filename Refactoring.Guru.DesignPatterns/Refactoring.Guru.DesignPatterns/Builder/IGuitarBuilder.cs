namespace Refactoring.Guru.DesignPatterns.Builder
{
    public interface IGuitarBuilder
    {
        void Reset();
        void SetName(string name);
        void SetBody(string body);
        void SetNeck(string neck);
        void SetElectronics(string electronics);
        void SetStrings(string strings);
    }
}
