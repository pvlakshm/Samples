using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCoverageFile
{
    /// <summary>
    /// The exception for invalid coverage files.
    /// </summary>
    [global::System.Serializable]
    public class InvalidCoverageFileException : Exception
    {
        public InvalidCoverageFileException() { }
        public InvalidCoverageFileException(string message) : base(message) { }
        public InvalidCoverageFileException(string message, Exception inner) : base(message, inner) { }
        protected InvalidCoverageFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }
    }
}
