using JSONInventoryManagement.InventoryDataManagement;

namespace JSONInventoryManagement
{
    internal class Program
    {
        static string jsonFilePath = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\InventoryManagement-JSON\JSONInventoryManagement\InventoryDataManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("JSON Inventory Management!");
            InventoryDetailManagement inventory = new InventoryDetailManagement();
            inventory.ReadJSONFile(jsonFilePath);
        }
    }
}