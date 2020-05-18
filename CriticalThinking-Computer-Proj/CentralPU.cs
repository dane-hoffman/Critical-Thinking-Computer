using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking_Computer_Proj
{
    class CentralPU
    {
        public string manufacturer;
        public string name;





        public CentralPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;


        }

        public void ProcessInstall(Applications application, HardDrive hardDrive, RAM ram)
        {
                 if (CheckRequirements == true)
                 {
                    hardDrive.applicationsInHardDrive.Add(application);
                 }
                else
                {
                    Console.WriteLine("Error: system does not have enough RAM access memory");
                }




            


        }

        public bool CheckRequirements true (Applications application, HardDrive hardDrive, RAM ram)
        {
            bool ram.totalGigabytes > application.requiredRAM = true;




        }



    }
}
