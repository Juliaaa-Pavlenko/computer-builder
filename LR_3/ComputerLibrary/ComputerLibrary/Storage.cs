using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLibrary
{
    public class Storage
    {
        private StorageType _storageType { get; set; }
        private StorageSize _size { get; set; }

        public Storage (StorageType storageType, StorageSize size)
        {
            _storageType = storageType;
            _size = size;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Storage type: ");
            sb.Append(_storageType);
            sb.Append(", size: ");
            sb.Append(_size);
            return sb.ToString();
        }
    }
}
