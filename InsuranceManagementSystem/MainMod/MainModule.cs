//using System;
//using System.Collections.Generic;
//using InsuranceManagementSystem.DAO;
//using InsuranceManagementSystem.Entities;
//using InsuranceManagementSystem.MyExceptions;

//namespace InsuranceManagementSystem.MainMod
//{
//    public class MainModule
//    {
//        private static IPolicyService policyService = new PolicyServiceImpl();

//        public static void Main(string[] args)
//        {
//            bool continueRunning = true;

//            while (continueRunning)
//            {
//                Console.Clear();
//                Console.WriteLine("Insurance Management System - Main Menu");
//                Console.WriteLine("1. Create Policy");
//                Console.WriteLine("2. Get Policy");
//                Console.WriteLine("3. Get All Policies");
//                Console.WriteLine("4. Update Policy");
//                Console.WriteLine("5. Delete Policy");
//                Console.WriteLine("6. Exit");
//                Console.Write("Please choose an option (1-6): ");

//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        CreatePolicy();
//                        break;
//                    case "2":
//                        GetPolicy();
//                        break;
//                    case "3":
//                        GetAllPolicies();
//                        break;
//                    case "4":
//                        UpdatePolicy();
//                        break;
//                    case "5":
//                        DeletePolicy();
//                        break;
//                    case "6":
//                        continueRunning = false;
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice, please try again.");
//                        break;
//                }

//                if (continueRunning)
//                {
//                    Console.WriteLine("Press any key to continue...");
//                    Console.ReadKey();
//                }
//            }
//        }

//        private static void CreatePolicy()
//        {
//            try
//            {
//                Console.Write("Enter Policy Name: ");
//                string name = Console.ReadLine();
//                Console.Write("Enter Policy Details: ");
//                string details = Console.ReadLine();

//                Policy policy = new Policy { PolicyName = name, PolicyDetails = details };

//                bool result = policyService.CreatePolicy(policy);
//                if (result)
//                    Console.WriteLine("Policy created successfully.");
//                else
//                    Console.WriteLine("Error while creating policy.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }

//        private static void GetPolicy()
//        {
//            try
//            {
//                Console.Write("Enter Policy Id: ");
//                int policyId = int.Parse(Console.ReadLine());

//                Policy policy = policyService.GetPolicy(policyId);
//                if (policy != null)
//                {
//                    policy.PrintPolicyDetails();
//                }
//                else
//                {
//                    Console.WriteLine("Policy not found.");
//                }
//            }
//            catch (PolicyNotFoundException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }

//        private static void GetAllPolicies()
//        {
//            try
//            {
//                List<Policy> policies = policyService.GetAllPolicies();
//                if (policies.Count > 0)
//                {
//                    foreach (var policy in policies)
//                    {
//                        policy.PrintPolicyDetails();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("No policies found.");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }

//        private static void UpdatePolicy()
//        {
//            try
//            {
//                Console.Write("Enter Policy Id to update: ");
//                int policyId = int.Parse(Console.ReadLine());
//                Console.Write("Enter New Policy Name: ");
//                string name = Console.ReadLine();
//                Console.Write("Enter New Policy Details: ");
//                string details = Console.ReadLine();

//                Policy policy = new Policy { PolicyId = policyId, PolicyName = name, PolicyDetails = details };

//                bool result = policyService.UpdatePolicy(policy);
//                if (result)
//                    Console.WriteLine("Policy updated successfully.");
//                else
//                    Console.WriteLine("Error while updating policy.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }

//        private static void DeletePolicy()
//        {
//            try
//            {
//                Console.Write("Enter Policy Id to delete: ");
//                int policyId = int.Parse(Console.ReadLine());

//                bool result = policyService.DeletePolicy(policyId);
//                if (result)
//                    Console.WriteLine("Policy deleted successfully.");
//                else
//                    Console.WriteLine("Error while deleting policy.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//        }
//    }
//}
