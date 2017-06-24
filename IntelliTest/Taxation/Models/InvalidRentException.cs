namespace Models
{
    using System;

    public class InvalidRentException : Exception
    {
        public InvalidRentException() { }
        public InvalidRentException(
            string message) : base(message) { }
    }
}
