namespace FurnitureAssignment
{
    public abstract class Furniture
    {
        public Boolean Wood { get; set; }
        public Boolean Steel { get; set; }
        public Boolean Fabric { get; set; }
        public TypeOfFurniture TypeOfFurniture { get; set; }
        public string Name { get; set; }


        public Furniture(Boolean wood, Boolean steel, Boolean fabric, TypeOfFurniture typeOfFurniture, string name)
        {
            this.Wood = wood;
            this.Steel = steel;
            this.Fabric = fabric;
            this.TypeOfFurniture = typeOfFurniture;
            this.Name = name;
        }
    }
}
