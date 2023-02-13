using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Module._8.Files
{
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var Contact = new Contact("Дмитрий", 79992338869, "crazygoup777@gmail.com");

            var Formatter = new BinaryFormatter();

            using (var fs = new FileStream("Contacts.dat", FileMode.OpenOrCreate))
            {
                Formatter.Serialize(fs, Contact);
                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("Contacts.dat", FileMode.OpenOrCreate))
            {
                var newContact = (Contact)Formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newContact.Name} --- Телефон: {newContact.PhoneNumber}");
            }
        }
    }  
}

