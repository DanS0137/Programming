using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.Services
{
    public static class StoreSerializer
    {
        public static Store LoadStore()
        {
            Store store = new Store();

            string path = Environment.ExpandEnvironmentVariables("%appdata%") + @"\OOP";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path + @"\Customers");
            }
            else if (!Directory.Exists(path + @"\Customers"))
            {
                Directory.CreateDirectory(path + @"\Customers");
            }
            var directory = new DirectoryInfo(path + @"\Customers");
            FileInfo[] files = directory.GetFiles();
            Customer customer;
            foreach (FileInfo file in files)
            {
                StreamReader sr = new StreamReader(file.FullName);
                int id = Convert.ToInt16(file.Name);
                string fullName = sr.ReadLine();
                int postIndex = Convert.ToInt32(sr.ReadLine());
                string country = sr.ReadLine();
                string city = sr.ReadLine();
                string street = sr.ReadLine();
                string building = sr.ReadLine();
                string appartment = sr.ReadLine();
                customer = new Customer(id, fullName, postIndex, country, city, street, building, appartment);
                store.Customers.Add(customer);
                sr.Close();
            }

            path = Environment.ExpandEnvironmentVariables("%appdata%") + @"\OOP";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path + @"\Items");
            }
            else if (!Directory.Exists(path + @"\Items"))
            {
                Directory.CreateDirectory(path + @"\Items");
            }
            directory = new DirectoryInfo(path + @"\Items");
            files = directory.GetFiles();
            Item item;
            foreach (FileInfo file in files)
            {
                StreamReader sr = new StreamReader(file.FullName);
                int id = Convert.ToInt16(file.Name);
                double cost = Convert.ToDouble(sr.ReadLine());
                Category category = (Category)Enum.Parse(typeof(Category), sr.ReadLine());
                string name = sr.ReadLine();
                string info = sr.ReadToEnd();
                item = new Item(id, name, category, info, cost);
                store.Items.Add(item);
                sr.Close();
            }
            
            return store;
        }

        public static void DeleteElement(Item item)
        {
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Items\" + $"{item.Id}";
            File.Delete(path);
        }

        public static void DeleteElement(Customer customer)
        {
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\OOP\Customers\" + $"{customer.Id}";
            File.Delete(path);
        }

        public static void SaveStore(Store store)
        {
            foreach (Item item in store.Items)
            {
                string path = Environment.ExpandEnvironmentVariables("%appdata%")
                    + @"\OOP\Items\" + $"{item.Id}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(item.Cost.ToString() + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(item.Category.ToString() + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(item.Name + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(item.Info);
                    fs.Write(info, 0, info.Length);
                }
            }

            foreach (Customer customer in store.Customers)
            {
                string path = Environment.ExpandEnvironmentVariables("%appdata%")
                    + @"\OOP\Customers\" + $"{customer.Id}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(customer.FullName + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.Index.ToString() + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.Country + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.City + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.Street + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.Building + "\n");
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(customer.Address.Apartment);
                    fs.Write(info, 0, info.Length);
                }
            }
        }
    }
}
