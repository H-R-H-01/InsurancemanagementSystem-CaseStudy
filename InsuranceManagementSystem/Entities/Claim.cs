namespace InsuranceManagementSystem.Entities
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public DateTime DateFiled { get; set; }
        public decimal ClaimAmount { get; set; }
        public string C_Status { get; set; }
        public string C_Policy { get; set; }
        public int ClientId { get; set; }
        public Claim() { }

        public Claim(int claimId, string claimNumber, DateTime dateFiled, decimal claimAmount, string status, string policy, int clientId)
        {
            ClaimId = claimId;
            ClaimNumber = claimNumber;
            DateFiled = dateFiled;
            ClaimAmount = claimAmount;
            C_Status = status;
            C_Policy = policy;
            ClientId = clientId;
        }
        public void PrintClaimDetails()
        {
            Console.WriteLine($"ClaimId: {ClaimId}, ClaimNumber: {ClaimNumber}, DateFiled: {DateFiled}, Amount: {ClaimAmount}, Status: {C_Status}, Policy: {C_Policy}, ClientId: {ClientId}");
        }
    }
}
