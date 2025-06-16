using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    /// <summary>
    /// Класс для сохранения и загрузки контактов в/из файлы(-ов).
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь по умолчанию.
        /// </summary>
        private readonly static string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Contacts";

        /// <summary>
        /// Метод для загрузки файлов контактов.
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Contact> LoadContacts()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            if (!Directory.Exists(Path))
            {
                return contacts;
            }
            string[] files = Directory.GetFiles(Path);
            foreach (string filename in files)
            {
                contacts.Add(JsonConvert.DeserializeObject<Contact>(File.ReadAllText(filename))); 
            }
            return contacts;
        }

        /// <summary>
        /// Метод для сохранения контактов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void SaveContacts(ObservableCollection<Contact> contacts)
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            else
            {
                DirectoryInfo contactDirectoryInfo =  new DirectoryInfo(Path);
                foreach (FileInfo file in contactDirectoryInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            int count = 0;
            foreach (Contact contact in contacts)
            {
                File.WriteAllText(Path + $"/{count}.json", JsonConvert.SerializeObject(contact));
                count += 1;
            }
        }
    }
}
