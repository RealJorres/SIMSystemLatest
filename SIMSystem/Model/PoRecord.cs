using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class PoRecord
    {
        private string _id;
        private string _supplyName;
        private int _supplyCount;
        private int _supplyTotalCost;

        public PoRecord() { }

        public string Id { get => _id; set => _id = value; }
        public string SupplyName { get => _supplyName; set => _supplyName = value; }
        public int SupplyCount { get => _supplyCount; set => _supplyCount = value; }
        public int SupplyTotalCost { get => _supplyTotalCost; set => _supplyTotalCost = value; }
    }
}
