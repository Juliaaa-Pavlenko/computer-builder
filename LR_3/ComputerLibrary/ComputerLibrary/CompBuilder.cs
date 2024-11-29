using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class ComputerBuilder : ICompBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _computer = new Computer();
        }
        public void SetName(string name)
        {
            _computer.Name = name;
        }
        public void SetCPU(CPU cpu)
        {
            _computer.CPU = cpu;
        }

        public void SetGPU(GPU gpu)
        {
            _computer.GPU = gpu;
        }

        public void SetRAM(RAM ram)
        {
            _computer.RAM = ram;
        }

        public void SetStorage(Storage storage)
        {
            _computer.Storage = storage;
        }

        public void SetPowerSupply(PowerSupply powerSupply)
        {
            _computer.PowerSupply = powerSupply;
        }

        public void SetCoolingSystem(Cooling Cooling)
        {
            _computer.Cooling = Cooling;
        }

        public Computer GetResult()
        {
            return _computer;
        }
    }
}
