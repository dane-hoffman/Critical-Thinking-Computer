using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking_Computer_Proj
{
    class Computer
    {
        public MotherBoard motherboard;
        public HardDrive hardDrive;
        public CentralPU cpu;
        public RAM ram;
        public GraphicsPU gpu;
        public Applications applications;
        public Games game;


        public Computer()
        {
            HardDrive hardDrive = new HardDrive(1000, 1000);
            RAM ram = new RAM(1000, "Intel");
            CentralPU cpu = new CentralPU("Intel", "Doobie");
            GraphicsPU gpu = new GraphicsPU("Bleep Co.", 1000);
            MotherBoard motherBoard = new MotherBoard("BlackHat", ram, cpu, gpu, hardDrive);


        }

        public void RunComputer()
        {
            cpu.ProcessInstall(applications, hardDrive,ram, gpu,game);

        }

        //public void BuildComputer()
        //{
        //    HardDrive hardDrive = new HardDrive(1000, 1000);
        //    RAM ram = new RAM(1000, "Intel");
        //    CentralPU cpu = new CentralPU("Intel", "Doobie");
        //    GraphicsPU gpu = new GraphicsPU("Bleep Co.", 1000);
        //    MotherBoard motherBoard = new MotherBoard("BlackHat", ram, cpu, gpu, hardDrive);


        //}

    }
}
