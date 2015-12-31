using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace UZWMI
{
    class Query_SelectQuery
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Version 1.777");

            ManagementScope scope = new ManagementScope(@"ROOT\cimv2");
            //SelectQuery selectQuery = new
            //    SelectQuery(@"root\cimv2\power\Win32_Battery");
            //ManagementObjectSearcher searcher =
            //    new ManagementObjectSearcher(selectQuery);

            WqlObjectQuery wqlQuery =
            new WqlObjectQuery("SELECT * from CIM_PowerSupply");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, wqlQuery);


            foreach (ManagementObject obj in searcher.Get())
            {
                foreach (PropertyData property in obj.Properties)
                {
                   Console.WriteLine("Prop: {0}   {1}", property.Name, property.Value);
                }
                //Console.WriteLine(disk.ToString());
            }


            Console.WriteLine("...");
            Console.ReadLine();
            return 0;
        }
    }
}

