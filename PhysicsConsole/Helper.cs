using System;
using System.Collections.Generic;
using System.Reflection;

namespace PhysicsConsole
{
    internal static class Helper
    {
        internal static List<string> GetClasses(string nameSpace, Assembly physicsAssembly)
        {
            Assembly asm = physicsAssembly;

            List<string> namespacelist = new List<string>();
            List<string> classlist = new List<string>();

            foreach (Type type in asm.GetTypes())
            {
                    namespacelist.Add(type.Name);
            }

            foreach (string classname in namespacelist)
                classlist.Add(classname);

            return classlist;
        }
    }
}


