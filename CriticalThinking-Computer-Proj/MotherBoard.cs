using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking_Computer_Proj
{
    class MotherBoard
    {
        public string manufacturer;
        public CentralPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GraphicsPU graphics;






        public MotherBoard(string manufacturer, RAM ram, CentralPU cpu, GraphicsPU gpu, HardDrive hardDrive)
        {
            this.manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;


        }






    }
}
