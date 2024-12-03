using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class Computer
    {
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public Cooling Cooling { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Computer name: ");
            sb.Append(Name);
            sb.Append("\n");
            sb.Append(CPU);
            sb.Append("\n");
            sb.Append(GPU);
            sb.Append("\n");
            sb.Append(RAM);
            sb.Append("\n");
            sb.Append(Storage);
            sb.Append("\n");
            sb.Append(PowerSupply);
            sb.Append("\n");
            sb.Append(Cooling);
            return sb.ToString();
        }
    }
}
