using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class Director
    {
        public void ConstructGamingPC(ICompBuilder builder)
        {
            builder.Reset();
            builder.SetCPU(new CPU(CPUType.gaming, CPUManufacturer.AMD, CPULine.Ryzen_7_5750G_PRO));
            builder.SetGPU(new GPU(GPUType.gaming, GPUManufacturer.GeForce, GPULine.GV_N730D5_2GL));
            builder.SetRAM(new RAM(RAMType.DDR2, RAMSize._16GB));
            builder.SetStorage(new Storage(StorageType.SSD, StorageSize._512));
            builder.SetPowerSupply(new PowerSupply(PowerSupplyStrength._500to650));
            builder.SetCoolingSystem(new Cooling(CoolingType.water));
        }

        public void ConstructOfficePC(ICompBuilder builder)
        {
            builder.Reset();
            builder.SetCPU(new CPU(CPUType.office, CPUManufacturer.Intel, CPULine.Core_i3_12100));
            builder.SetGPU(new GPU(GPUType.office, GPUManufacturer.ASUS, GPULine.RTX_4090));
            builder.SetRAM(new RAM(RAMType.DDR, RAMSize._4GB));
            builder.SetStorage(new Storage(StorageType.SSD, StorageSize._1024));
            builder.SetPowerSupply(new PowerSupply(PowerSupplyStrength._300to450));
            builder.SetCoolingSystem(new Cooling(CoolingType.passive));
        }
    }
}
