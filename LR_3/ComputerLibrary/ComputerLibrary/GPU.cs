using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class GPU
    {
        private GPUType _gpuType { get; set; }
        private GPUManufacturer _gpuManufacturer { get; set; }
        private GPULine _gpuLine { get; set; }

        public GPU(GPUType gpuType, GPUManufacturer gpuManufacturer, GPULine gpuLine)
        {
            _gpuType = gpuType;
            _gpuManufacturer = gpuManufacturer;
            _gpuLine = gpuLine;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GPU type: ");
            sb.Append(_gpuType);
            sb.Append(", Manufacturer: ");
            sb.Append(_gpuManufacturer);
            sb.Append(", Line: ");
            sb.Append(_gpuLine);
            return sb.ToString();
        }
    }
}
