using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class Cooling
    {
        private CoolingType _type { get; set; }

        public Cooling(CoolingType type)
        {
            _type = type;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cooling type: ");
            sb.Append(_type);
            return sb.ToString();
        }
    }
}
