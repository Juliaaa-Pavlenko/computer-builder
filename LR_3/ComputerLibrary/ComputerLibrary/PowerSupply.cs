using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class PowerSupply
    {
        private PowerSupplyStrength _powerSupplyStrength { get; set; }

        public PowerSupply(PowerSupplyStrength powerSupplyStrength)
        {
            _powerSupplyStrength = powerSupplyStrength;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Power Supply Strength: ");
            sb.Append(_powerSupplyStrength);
            return sb.ToString();
        }
    }
}
