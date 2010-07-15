using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using log4net;
using log4net.Config;
namespace onetoonethousand
{
    class Program
    {
        private static ILog log = LogManager.GetLogger("");
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            List<String> alphabeticalRepresentations = new List<string>();
            for (int i = 1; i <= 1000; i++)
            {
                alphabeticalRepresentations.Add(i.GetAlphabeticalRepresentation());
            }

            foreach (String s in alphabeticalRepresentations)
                log.Debug(s);
            Console.WriteLine(alphabeticalRepresentations.Sum(b => b.Replace(" ","").Length));
            Console.ReadLine();
        }

     
    }
}
