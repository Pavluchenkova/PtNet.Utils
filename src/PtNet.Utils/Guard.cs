using System;

namespace PtNet.Utils
{
    public static class Guard
    {
        public static void ArgumentNotNull(object argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException($"Argument {argumentName} is NULL.");
            }
        }
    }
}
