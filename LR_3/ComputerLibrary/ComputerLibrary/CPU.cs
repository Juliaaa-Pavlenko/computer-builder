using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class CPU
    {
        private CPUType _cpuType { get; set; }
        private CPUManufacturer _cpuManufacturer { get; set; }
        private CPULine _cpuLine { get; set; }

        public CPU(CPUType cpuType, CPUManufacturer cpuManufacturer, CPULine cpuLine)
        {
            _cpuType = cpuType;
            _cpuManufacturer = cpuManufacturer;
            _cpuLine = cpuLine;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CPU type: ");
            sb.Append(_cpuType);
            sb.Append(", Manufacturer: ");
            sb.Append(_cpuManufacturer);
            sb.Append(", Line: ");
            sb.Append(_cpuLine);
            return sb.ToString();
        }
    }
}
