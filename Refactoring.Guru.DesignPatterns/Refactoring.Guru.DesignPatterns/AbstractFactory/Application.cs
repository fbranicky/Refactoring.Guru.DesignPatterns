using System;

namespace Refactoring.Guru.DesignPatterns.AbstractFactory
{
    /// <summary>
    /// An abstract factory creates objects that are somehow related without specifying concrete implementations.
    /// In this example, a guitar shop creates packages of gear based on a genre.
    /// </summary>

    public class Application
    {
        private IGenreFactory _genreFactory;
        private IElectricGuitar _electricGuitar;
        private IAmplifier _amplifier;

        public Application(string genre)
        {
            SetFactory(genre);
            BuildStuff();
        }

        public IAmplifier GetAmplifier()
        {
            return _amplifier;
        }

        public IElectricGuitar GetGuitar()
        {
            return _electricGuitar;
        }

        private void SetFactory(string genre)
        {
            if (genre.Equals("country", StringComparison.OrdinalIgnoreCase))
            {
                _genreFactory = new CountryFactory();
            }
            else if (genre.Equals("surf", StringComparison.OrdinalIgnoreCase))
            {
                _genreFactory = new SurfFactory();
            }
            else
            {
                throw new ArgumentException($"Unknown genre: {genre}", "genre");
            }
        }

        private void BuildStuff()
        {
            _electricGuitar = _genreFactory.CreateGuitar();
            _amplifier = _genreFactory.CreateAmplifier();
        }
    }
}
