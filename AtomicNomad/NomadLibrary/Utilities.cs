using System;

namespace NomadLibrary
{
    public static class Utilities
    {
        public static string HelloWorld()
        {
            return "Hello, World! It is currently " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + ".";
        }
    }
}
