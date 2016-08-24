using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dbbr
{
    class Program
    {
        private const string SourceNameKey = "source-name";
        private const string SourceDbKey = "source-db";
        private const string TargetNameKey = "target-name";
        private const string TargetDbKey = "target-db";

        static void Main(string[] args)
        {
            int count = 0;
            foreach (string arg in args)
            {
                bool isParameter = arg.StartsWith("--");
                if (isParameter)
                {
                    count++;
                }
            }
            if (args.Length != count * 2)
            {
                Console.WriteLine("Die Anzahl der Parameter stimmt nicht mit den erwateten Parametern überein. Die Anwendung wird beendet.");
                return;
            }
            Dictionary<string, string> argsDict = new Dictionary<string, string>();
            for (int i = 0; i < args.Length; i += 2)
            {
                int j = i + 1;
                string param = args[i].Remove(0, 2);
                string value = args[j];
                argsDict[param] = value;
                Console.WriteLine("{0}: {1}", param, value);
            }
            string sourceDb = argsDict[SourceDbKey];
            Console.WriteLine(sourceDb);
            Console.ReadLine();
        }
    }
}
