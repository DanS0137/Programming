using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сохранения и загрузки контактов в/из файлы(-ов).
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Путь по умолчанию.
        /// </summary>
        private static string Path = @"C:/Users/5731sda/Documents/Contacts";

        /// <summary>
        /// Метод для загрузки файла контакта.
        /// </summary>
        /// <returns></returns>
        public static Contact LoadContact()
        {
            if (!Directory.Exists(Path) || !File.Exists(Path + @"/contacts.json"))
            {
                return new Contact();
            }
            return JsonConvert.DeserializeObject<Contact>(File.ReadAllText(Path + @"/contacts.json"));
        }

        /// <summary>
        /// Метод для сохранения контакта в файл.
        /// </summary>
        /// <param name="contact">Объект контакта.</param>
        public static void SaveContact(Contact contact)
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            File.WriteAllText(Path + @"/contacts.json", JsonConvert.SerializeObject(contact));
        }
    }
}
