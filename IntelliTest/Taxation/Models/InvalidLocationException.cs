namespace Models
{
    using System;

    public class InvalidLocationException : Exception
    {
        public InvalidLocationException() { }
        public InvalidLocationException(
            string message) : base(message) { }
    }
}
