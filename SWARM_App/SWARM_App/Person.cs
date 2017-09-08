using System;
namespace SWARM_App
{
    public class Person
    {
        public string Name { get; private set; }

        public string ID { get; private set; }

        public string Address { get; private set; }

        public string Phone { get; set; }

        public Person(string name, string id, string address, string phone)
        {
            Name = name;
            ID = id;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}

