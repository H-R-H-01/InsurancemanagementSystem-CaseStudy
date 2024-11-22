using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InsuranceManagementSystem.Entities;
using InsuranceManagementSystem.Util;

namespace InsuranceManagementSystem.DAO
{
    public class InsuranceServiceImpl : IInsuranceService
    {
        public bool CreatePolicy(Policy policy)
        {
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "INSERT INTO Policies (PolicyName, PolicyDetails) VALUES (@PolicyName, @PolicyDetails)";
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PolicyName", policy.PolicyName);
                        cmd.Parameters.AddWithValue("@PolicyDetails", policy.PolicyDetails);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating policy: " + ex.Message);
                return false;
            }
        }


        public Policy GetPolicy(int policyId)
        {
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "SELECT * FROM Policies WHERE PolicyId = @PolicyId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PolicyId", policyId);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                return new Policy(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2)
                                );
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving policy: " + ex.Message);
                return null;
            }
        }

        public List<Policy> GetAllPolicies()
        {
            var policies = new List<Policy>(); 
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "SELECT * FROM Policies";
                    connection.Open(); 
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            policies.Add(new Policy(
                                reader.GetInt32(0),  // PolicyId
                                reader.GetString(1), // PolicyName
                                reader.GetString(2)  // PolicyDetails
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving policies: " + ex.Message);
            }

            return policies; 
        }


        public bool UpdatePolicy(Policy policy)
        {
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "UPDATE Policies SET PolicyName = @PolicyName, PolicyDetails = @PolicyDetails WHERE PolicyId = @PolicyId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PolicyName", policy.PolicyName);
                        cmd.Parameters.AddWithValue("@PolicyDetails", policy.PolicyDetails);
                        cmd.Parameters.AddWithValue("@PolicyId", policy.PolicyId);
                        connection.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating policy: " + ex.Message);
                return false;
            }
        }

        public bool DeletePolicy(int policyId)
        {
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "DELETE FROM Policies WHERE PolicyId = @PolicyId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PolicyId", policyId);
                        connection.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting policy: " + ex.Message);
                return false;
            }
        }
    }
}
