using static FurnitureAssignment.TypeOfFurniture; //need it for the enum

namespace FurnitureAssignment
{
    public class FurnitureStorage
    {
        //make the lists into properties (so that we don't have to keep sending/returning them)
        private readonly List<Lamp> lamps;
        private readonly List<Table> tables;

        public FurnitureStorage() //a constructor to keep it from complaining about the lists being null
        {
            lamps = new List<Lamp>(); 
            tables = new List<Table>();
        }
        
        public void FurnitureStorageMethod()
        {
            Random random = new Random();

            //create random furniture
            CreateLamp(random);
            CreateTable(random);

            //print the lists
            PrintTables();
            PrintLamps();
            Console.ReadLine();

            //sort the lists
            lamps.Sort();
            tables.Sort();

            //print the lists again
            PrintTables();
            PrintLamps();
        }

        #region PrintList 
        public void PrintTables()
        {
            foreach (Table table in tables)
            {
                Console.Write(table);
                Console.WriteLine($" och är av typen: {table.TypeOfFurniture.FurnitureType}");
            }
        }
        public void PrintLamps()
        {
            foreach (Lamp lamp in lamps)
            {
                Console.Write(lamp);
                Console.WriteLine($" och är av typen: {lamp.TypeOfFurniture.FurnitureType}");
            }
        }
        #endregion

        #region CreateFurniture 
        public List<Lamp> CreateLamp(Random random)
        {
            for (int i = 0; i < 10; i++)
            {
                TypeOfFurniture typeObject = new TypeOfFurniture(RandomLamp(random.Next(0, 2)));
                lamps.Add(new Lamp((random.Next(10, 100)), false, true, false, typeObject, $"Lamp {i + 1}"));
            }
            return lamps;
        }
        public List<Table> CreateTable(Random random)
        {
            for (int i = 0; i < 10; i++)
            {
                TypeOfFurniture typeObject = new TypeOfFurniture(RandomTable(random.Next(0, 2)));
                tables.Add(new Table((random.Next(1, 5)), false, true, false, typeObject, $"Table {i + 1}"));
            }
            return tables;
        }

        #region RandomType 
        public string RandomLamp(int random)
        {
            switch (random)
            {
                case 0:
                    return EnumForFurniture.Taklampa.ToString();
                case 1:
                    return EnumForFurniture.Bordslampa.ToString();
                default:
                    return "";
            }
        }
        public string RandomTable(int random)
        {
            switch (random)
            {
                case 0:
                    return EnumForFurniture.Bord.ToString();
                case 1:
                    return EnumForFurniture.Skrivbord.ToString();
                default:
                    return "";
            }
        }
        #endregion

        #endregion
    }
}
