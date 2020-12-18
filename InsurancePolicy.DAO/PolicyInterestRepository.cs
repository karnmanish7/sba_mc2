using Cassandra;
using InsurancePolicy.Entities;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace InsurancePolicy.DAO
{
    /// <summary>
    /// This class is used to maintain operations with Cassandra DB
    /// </summary>
    public class PolicyInterestRepository
    {
        string keySpace = "policydb";
        ISession session;
        Cluster cluster;

        /// <summary>
        /// Setup connection with Cassandra and also create keyspace and table.
        /// It should initialize a global cluster object to be used with other methods.
        /// </summary>
        public PolicyInterestRepository()
        {
            //Establish the connection with cassandra cluster
            // Also create Keyspace and Table
        }

        /// <summary>
        /// This method is used to Add a record in table when user shows interest in a policy.
        /// </summary>
        /// <param name="interest">InterestInfo object. Refer to InterestInfo model.</param>
        public void AddInterest(string keyspacename,InterestInfo interest)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to fetch all details of Interests shown in a specific policy
        /// </summary>
        /// <param name="policyName">Policy Name</param>
        /// <returns>List of Interest Info</returns>
        public List<InterestInfo> GetInterests(string policyName)
        {
            throw new NotImplementedException();
        }

        //Don't change this method
        public void Clean()
        {
            session = cluster.Connect(keySpace);
            session.Execute($"Truncate policyinterest", ConsistencyLevel.LocalQuorum);
        }

        static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }
    }
}
