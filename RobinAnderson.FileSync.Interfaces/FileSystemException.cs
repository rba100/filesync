using System;
using System.Runtime.Serialization;

namespace RobinAnderson.FileSync.Interfaces
{
    [Serializable]
    public class FileSystemException : Exception
    {
        public FileSystemException() : this("An error occured accessing the file system.")
        {
        }

        public FileSystemException(string message) : base(message)
        {
        }

        public FileSystemException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileSystemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
