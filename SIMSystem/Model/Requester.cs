using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class Requester
    {
        string name;
        string ris_number;
        string designation;
        byte[] signature;
    
        public Requester()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Ris_number { get => ris_number; set => ris_number = value; }
        public string Designation { get => designation; set => designation = value; }
        public byte[] Signature { get => signature; set => signature = value; }
    }
}
