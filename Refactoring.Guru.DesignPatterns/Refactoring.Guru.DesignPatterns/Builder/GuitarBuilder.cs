namespace Refactoring.Guru.DesignPatterns.Builder
{
    public class GuitarBuilder : IGuitarBuilder
    {
        private Guitar _guitar;

        public GuitarBuilder()
        {
            Reset();
        }

        public Guitar GetGuitar()
        {
            Guitar g = _guitar;

            Reset();

            return g;
        }

        public void Reset()
        {
            _guitar = new Guitar();
        }

        public void SetName(string name)
        {
            _guitar.Name = name;
        }

        public void SetBody(string body)
        {
            _guitar.Body = body;
        }

        public void SetElectronics(string electronics)
        {
            _guitar.Electronics = electronics;
        }

        public void SetNeck(string neck)
        {
            _guitar.Neck = neck;
        }

        public void SetStrings(string strings)
        {
            _guitar.Strings = strings;
        }
    }
}
