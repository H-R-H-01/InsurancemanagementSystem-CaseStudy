using InsuranceManagementSystem.Entities;

namespace InsuranceManagementSystem.DAO
{
    public interface IInsuranceService
    {
        bool CreatePolicy(Policy policy);
        Policy GetPolicy(int policyId);
        List<Policy> GetAllPolicies();
        bool UpdatePolicy(Policy policy);
        bool DeletePolicy(int policyId);
    }
}
