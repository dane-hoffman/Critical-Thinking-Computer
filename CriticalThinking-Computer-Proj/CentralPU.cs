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

            

        }

        public bool CheckRequirements(Applications application, HardDrive hardDrive, RAM ram)
        {
            if (ram.totalGigabytes > application.requiredRAM)
            {



            }

        }



    }
}
