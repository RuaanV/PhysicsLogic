using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Diagnostics;
using System.Reflection;
using log4net.Config;

namespace PhysicsConsole
{
    class Console
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Console));

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string executingAssembly = Assembly.GetExecutingAssembly().GetName().ToString();
            string executingAssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string interfaceAssemblyVersion = typeof(QuantumTheory.StandardModel.ElementaryParticle).Assembly.GetName().Version.ToString();
            string implementationAssemblyVersion = typeof(QuantumTheory.StandardModel.Fermion.Quark).Assembly.GetName().Version.ToString();


            log.Info("Starting Physics Console Runner");
            log.Debug(string.Format("Executing Assembly {0}", executingAssembly));
            log.Debug(string.Format("Physics Interface Assembly Version {0}", interfaceAssemblyVersion));
            log.Debug(string.Format("Physics Implementation Assembly Version {0}", implementationAssemblyVersion));

            log.Info("Standard Particle Model use for the simulation is:");

            System.Console.ReadLine();

            //Get classes from Physics Logic Assembly
            var classes = Helper.GetClasses("QuantumTheory.StandardModel", typeof(QuantumTheory.StandardModel.Fermion.Quark).Assembly);
            foreach (string _class in classes)
            { 
                sb.AppendLine(_class);
            }

            log.Info(sb);
            System.Console.ReadLine();

        }
    }
}
