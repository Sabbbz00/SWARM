using System;
namespace SWARM_App
{
    public class Client : Person
    {
        public string ClientType { get; set; }
        public string ClientID { get; set; }

        public Client(){}
        public Client(string name, string address, string phone, string email, string clientType, string clientid)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            ClientType = clientType;
            ClientID = clientid;
        }
    }
}
