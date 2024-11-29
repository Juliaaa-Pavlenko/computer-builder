using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public interface ICompBuilder
    {
        void SetName(string name);
        void Reset();
        void SetCPU(CPU cpu);
        void SetGPU(GPU gpu);
        void SetRAM(RAM ram);
        void SetStorage(Storage storage);
        void SetPowerSupply(PowerSupply powerSupply);
        void SetCoolingSystem(Cooling Cooling);
        Computer GetResult();
    }
}
