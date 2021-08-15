namespace Refactoring.Guru.DesignPatterns.Prototype
{
    public class Guitar
    {
        private decimal _msrp;
        public decimal GetMsrp()
        {
            return _msrp;
        }

        public string Name { get; set; }
        public PickupConfiguration Pickups;

        public Guitar(decimal msrp)
        {
            _msrp = msrp;
        }

        public class PickupConfiguration
        {
            public int Quantity;
        }

        public Guitar ShallowCopy()
        {
            return (Guitar)MemberwiseClone();
        }

        public Guitar DeepCopy()
        {
            var g = (Guitar)MemberwiseClone();

            //create new reference types in memory independent of source object
            g.Pickups = new PickupConfiguration { Quantity = this.Pickups.Quantity };

            return g;
        }
    }
}
