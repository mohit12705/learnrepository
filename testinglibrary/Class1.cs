using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Configuration;
using System.Reflection;


namespace testinglibrary
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void test()
        {
            int a = 30;

            var testname = Properties.names1.Default.Properties;
            Console.WriteLine("wed");
            List<string> names = new List<string >();
            foreach (SettingsProperty currentProperty in Properties.names1.Default.Properties)
            {
                names.Add(currentProperty.Name);
             
            }

             //   Properties.names1.Default.name1;
             //  Console.ReadKey();
        }
    }
}
