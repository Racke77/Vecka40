using System;
using System.Collections.Generic;
using System.Linq;
namespace FurnitureAssignment
{
    public class Table:Furniture, IComparable
    {
        double AreaOfTable { get; set; }
        public Table(double areaOfTable, Boolean wood, Boolean steel, Boolean fabric, TypeOfFurniture typeOfFurniture, string name) :base(wood, steel, fabric, typeOfFurniture, name)
        {
            AreaOfTable = areaOfTable;
        }
        public int CompareTo(object? obj)
        {
            Table r = (Table)obj;
            if (this.AreaOfTable > r.AreaOfTable)
            {
                return 1;
            }
            else if (this.AreaOfTable == r.AreaOfTable)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"Bordet {Name} har ytan {AreaOfTable}";
        }

    }
}
