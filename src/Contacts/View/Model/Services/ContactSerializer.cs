using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    internal static class ContactSerializer
    {
        private static string Path = @"C:/Users/5731sda/Documents/Contacts";
        public static Contact LoadContact()
        {
            if (!Directory.Exists(Path) || !File.Exists(Path + @"/contacts.json"))
            {
                return new Contact();
            }
            return JsonConvert.DeserializeObject<Contact>(File.ReadAllText(Path + @"/contacts.json"));
        }
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
