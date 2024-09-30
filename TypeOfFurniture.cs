namespace FurnitureAssignment
{
    public class TypeOfFurniture
    {
        public string FurnitureType;
        public TypeOfFurniture(string furnitureType)
        {
            FurnitureType = furnitureType;
        }
        public enum EnumForFurniture //"enum" is a "static" class
        {
            Bord,
            Stol,
            Taklampa,
            Bordslampa,
            Skrivbord
        }
    }
}
