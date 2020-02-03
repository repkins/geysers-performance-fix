using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeysersPerformanceFix
{
    class Logger
    {
        static public void Info(string message)
        {
            string assemblyName = Assembly.GetCallingAssembly().GetName().Name;

            Console.WriteLine("[{0}/Info] {1}", assemblyName, message);
        }
        static public void Warning(string message)
        {
            string assemblyName = Assembly.GetCallingAssembly().GetName().Name;

            Console.WriteLine("[{0}/Warn] {1}", assemblyName, message);
        }
        static public void Error(string message)
        {
            string assemblyName = Assembly.GetCallingAssembly().GetName().Name;

            Console.WriteLine("[{0}/ERROR] {1}", assemblyName, message);
        }
        static public void Debug(string message)
        {
            string assemblyName = Assembly.GetCallingAssembly().GetName().Name;

            Console.WriteLine("[{0}/Debug] {1}", assemblyName, message);
        }
    }
}
