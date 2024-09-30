namespace FurnitureAssignment
{
    public class Lamp : Furniture, IComparable
    {
        double Current { get; set; }

        public Lamp(double current, Boolean wood, Boolean steel, Boolean fabric, TypeOfFurniture typeOfFurniture, string name) :base(wood, steel, fabric, typeOfFurniture, name)
        {
            Current = current;
        }

        public int CompareTo(object? obj)
        {
            Lamp r = (Lamp)obj;
            if (this.Current > r.Current)
            {
                return 1;
            }
            else if (this.Current == r.Current)
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
            return $"Lampan {Name} drar {Current} amp";
        }
    }
}
