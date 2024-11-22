using System;
using InsuranceManagementSystem.DAO;
using InsuranceManagementSystem.Entities;

namespace InsuranceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulating the menu and calling services

            IInsuranceService policyService = new InsuranceServiceImpl();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Create Policy");
                Console.WriteLine("2. Get Policy");
                Console.WriteLine("3. Update Policy");
                Console.WriteLine("4. Delete Policy");
                Console.WriteLine("5. Get All Policies");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Create policy
                        Console.Write("Enter Policy Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Policy Details: ");
                        string details = Console.ReadLine();

                        var policy = new Policy { PolicyName = name, PolicyDetails = details };
                        bool created = policyService.CreatePolicy(policy);
                        Console.WriteLine(created ? "Policy Created Successfully" : "Failed to Create Policy");
                        break;

                    case 2:
                        // Get policy
                        Console.Write("Enter Policy ID: ");
                        int policyId = Convert.ToInt32(Console.ReadLine());
                        var retrievedPolicy = policyService.GetPolicy(policyId);
                        if (retrievedPolicy != null)
                        {
                            Console.WriteLine($"Policy ID: {retrievedPolicy.PolicyId}, Name: {retrievedPolicy.PolicyName}, Details: {retrievedPolicy.PolicyDetails}");
                        }
                        else
                        {
                            Console.WriteLine("Policy Not Found");
                        }
                        break;

                    case 3:
                        // Update policy
                        Console.Write("Enter Policy ID to Update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        var updatePolicy = policyService.GetPolicy(updateId);

                        if (updatePolicy != null)
                        {
                            Console.Write("Enter New Policy Name: ");
                            updatePolicy.PolicyName = Console.ReadLine();
                            Console.Write("Enter New Policy Details: ");
                            updatePolicy.PolicyDetails = Console.ReadLine();

                            bool updated = policyService.UpdatePolicy(updatePolicy);
                            Console.WriteLine(updated ? "Policy Updated Successfully" : "Failed to Update Policy");
                        }
                        else
                        {
                            Console.WriteLine("Policy Not Found");
                        }
                        break;

                    case 4:
                        // Delete policy
                        Console.Write("Enter Policy ID to Delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        bool deleted = policyService.DeletePolicy(deleteId);
                        Console.WriteLine(deleted ? "Policy Deleted Successfully" : "Failed to Delete Policy");
                        break;

                    case 5:
                        // Get all policies
                        var policies = policyService.GetAllPolicies();
                        if (policies.Count > 0)
                        {
                            foreach (var p in policies)
                            {
                                Console.WriteLine($"ID: {p.PolicyId}, Name: {p.PolicyName}, Details: {p.PolicyDetails}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No policies found.");
                        }
                        break;

                    case 6:
                        // Exit
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
