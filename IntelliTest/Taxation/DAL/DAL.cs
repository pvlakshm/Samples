namespace DAL
{
    using System.IO;
    using Models;

    public class DAL : IDAL
    {
        public uint HRA(
            Employee e)
        {
            // return the same value for all employess as per busines rule. Or, return 0.
            if (File.Exists("config.data"))
            {
                var sr = new StreamReader("c:\\config.data");
                int i = sr.Read();
                return (uint)i;
            }

            return 0;
        }
    }
}
