using System.Runtime.Serialization;

namespace ConceptosPO
{
    [Serializable]
    internal class dayException : Exception
    {
        public dayException()
        {
        }

        public dayException(string? message) : base(message)
        {
        }

        public dayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected dayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}