using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class RAM
    {
        private RAMType _ramType { get; set; }
        private RAMSize _ramSize { get; set; }

        public RAM(RAMType ramType, RAMSize ramSize)
        {
            _ramType = ramType;
            _ramSize = ramSize;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("RAM type: ");
            sb.Append(_ramType);
            sb.Append(", Size: ");
            sb.Append(_ramSize);
            return sb.ToString();
        }
    }
}
