namespace FurnitureAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object so that we can run it outside of "static"
            FurnitureStorage furnitureStorage = new FurnitureStorage();
            furnitureStorage.FurnitureStorageMethod();
        }
    }
}
