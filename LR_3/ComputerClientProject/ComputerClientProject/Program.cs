using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using ComputerLibrary;
using System.IO;

namespace ComputerClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            ICompBuilder computerBuilder = new ComputerBuilder();
            director.ConstructGamingPC(computerBuilder);
            Computer gamingPC = computerBuilder.GetResult();

            ICompBuilder myPCbuilder = new ComputerBuilder();
            myPCbuilder.SetName("Julia");
            myPCbuilder.SetCPU(new CPU(CPUType.gaming, CPUManufacturer.AMD, CPULine.Ryzen_5_3400G));
            myPCbuilder.SetGPU(new GPU(GPUType.gaming, GPUManufacturer.GeForce, GPULine.GV_N730D5_2GL));
            myPCbuilder.SetRAM(new RAM(RAMType.DDR4, RAMSize._128GB));
            myPCbuilder.SetPowerSupply(new PowerSupply(PowerSupplyStrength._300to450));
            myPCbuilder.SetCoolingSystem(new Cooling(CoolingType.cooler));
            myPCbuilder.SetStorage(new Storage(StorageType.HDD, StorageSize._1024));
            Computer myComp = myPCbuilder.GetResult();

            Console.WriteLine(myComp);
            //Console.WriteLine(gamingPC);

            Console.ReadLine();
        }
    }
}
