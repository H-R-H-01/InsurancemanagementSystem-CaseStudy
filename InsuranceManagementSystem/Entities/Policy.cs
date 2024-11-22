namespace InsuranceManagementSystem.Entities
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDetails { get; set; }

        public Policy() { }

        public Policy(int policyId, string policyName, string policyDetails)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PolicyDetails = policyDetails;
        }
    }
}
