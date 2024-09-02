using System.Runtime.Serialization;

namespace ReturnManagementSystem.Exceptions
{
    [Serializable]
    public class UnauthorizedUserException : Exception
    {

        public UnauthorizedUserException(string? message) : base(message)
        {
        }

    }
}