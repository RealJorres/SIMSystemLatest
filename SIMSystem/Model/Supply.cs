using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class Supply
    {
        private string name;
        private string ponumber;
        private int quantity;
        private int clevel;
        private string type;
        private string unit;
        private string yearadded;
        private double unitcost;
        private double totalcost;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Supply(){
        
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int Clevel
        {
            get
            {
                return clevel;
            }

            set
            {
                clevel = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
            }
        }

        public string Yearadded
        {
            get
            {
                return yearadded;
            }

            set
            {
                yearadded = value;
            }
        }

        public double Unitcost
        {
            get
            {
                return unitcost;
            }

            set
            {
                unitcost = value;
            }
        }

        public double Totalcost
        {
            get
            {
                return totalcost;
            }

            set
            {
                totalcost = value;
            }
        }

        public string Ponumber { get => ponumber; set => ponumber = value; }
    }
}
