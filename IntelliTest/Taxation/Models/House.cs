namespace Models
{
    using System;

    public class House
    {
        private uint monthlyRent;

        public bool IsRented {
            get;
            set;
        }

        public Location Location {
            get;
            set;
        }

        public uint MonthlyRent
        {
            get
            {
                return this.monthlyRent;
            }

            set
            {
                if (value == 0)
                {
                    throw new InvalidRentException();
                }

                this.monthlyRent = value;
            }
        }
    }
}