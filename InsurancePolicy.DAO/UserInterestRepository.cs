using Gremlin.Net.Driver;
using InsurancePolicy.Entities;
using System;
using System.Collections.Generic;

namespace InsurancePolicy.DAO
{
    /// <summary>
    /// This class is used to implement the operation for Graph Database using Cosmos Gremlin.
    /// </summary>
    public class UserInterestRepository
    {
        GremlinClient gremlinClient = null;
        public UserInterestRepository()
        {
            
        }

        /// <summary>
        /// This method is used to add a policy vertex in Graph. Vertex id is identified by PolicyName.
        /// </summary>
        /// <param name="policy">Policy object</param>
        public void AddPolicy(Policy policy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to add an edge labelled as "showed_interest" between a user and policy.
        /// User vertex needs to be added and identified by emailId(if not exists)
        /// </summary>
        /// <param name="policyName">Name of the policy to identify the vertex</param>
        /// <param name="emailId">Email id of the user to create User vertex</param>
        public void AddInterest(string policyName, string emailId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to fetch all the User vertex who have a relationship "showed_interest" with given PolicyName
        /// </summary>
        /// <param name="policyName">Policy Name to identify the relationship with.</param>
        /// <returns>List of emailId of Users</returns>
        public List<string> GetInterestedUser(string policyName)
        {
            throw new NotImplementedException();
        }

        //Don't change this method
        public void Clean()
        {
            string userQuery = $"g.V().hasLabel('user').drop()";
            string policyQuery = $"g.V().hasLabel('policy').drop()";
            gremlinClient.SubmitAsync<dynamic>(policyQuery).Wait();
            gremlinClient.SubmitAsync<dynamic>(userQuery).Wait();
        }
    }
}
