using System;
namespace SWARM_App
{
    public class Client : Person
    {
        public int ClientType { get; set; }
        public string ClientID { get; set; }

        public Client(){}
        public Client(string name, string address, string phone, string email, int clientType, string clientid)
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
