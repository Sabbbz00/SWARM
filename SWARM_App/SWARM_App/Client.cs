using System;
namespace SWARM_App
{
    public class Client : Person
    {
        public int ClientType { get; set; }
        public string ClientID { get; set; }
        public Client(){}
        public Client(int clientType, string clientid)
        {
            ClientType = clientType;
            ClientID = clientid;
        }
    }
}
