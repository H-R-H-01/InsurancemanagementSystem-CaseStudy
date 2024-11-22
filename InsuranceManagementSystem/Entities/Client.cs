namespace InsuranceManagementSystem.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactInfo { get; set; }
        public string C_Policy { get; set; }

        public Client() { } // Default Constructor

        public Client(int clientId, string clientName, string contactInfo, string policy) // Parametrized Constructor
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            C_Policy = policy;
        }

        // print all member variables
        public void PrintClientDetails()
        {
            Console.WriteLine($"ClientId: {ClientId}, ClientName: {ClientName}, ContactInfo: {ContactInfo}, Policy: {C_Policy}");
        }
    }
}
