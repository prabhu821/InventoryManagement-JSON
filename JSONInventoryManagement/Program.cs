using JSONInventoryManagement.InventoryDataManagement;
using JSONInventoryManagement.InventoryManagement;

namespace JSONInventoryManagement
{
    internal class Program
    {
        static string jsonFilePath = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\InventoryManagement-JSON\JSONInventoryManagement\InventoryDataManagement\Inventory.json";
        static string jsonDataFilePath = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\InventoryManagement-JSON\JSONInventoryManagement\InventoryManagement\InventoryData.json";
        static void Main(string[] args)
        {
            Console.WriteLine("JSON Inventory Management!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1.InventoryDataManagement \n2.InventoryManagement \n3.Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InventoryDetailManagement inventory = new InventoryDetailManagement();
                        inventory.ReadJSONFile(jsonFilePath);
                        break;
                    case 2:
                        InventoryManagements inventoryManagement = new InventoryManagements();
                        inventoryManagement.ReadJSONFile(jsonDataFilePath);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}