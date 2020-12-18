using InsurancePolicy.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsurancePolicy.DAO
{
    /// <summary>
    /// This class is used to maintain all operations with Cosmos For MongoDB
    /// </summary>
    public class PolicyInfoRepository
    {
        //Define IMongoCollection named as Policies mapped to PolicyInfo

        /// <summary>
        /// Constructor should setup the connection with Cosmos For MongoDB
        /// </summary>
        public PolicyInfoRepository()
        {
            
        }

        /// <summary>
        /// This method is used to Add a new Policy Information in MongoDB
        /// </summary>
        /// <param name="providerName">Policy Provider Name, In which policy needs to be added</param>
        /// <param name="policy">Policy Object</param>
        /// <returns></returns>
        public async Task AddNewPolicy(string providerName, Policy policy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to fetch all policies by provider.
        /// </summary>
        /// <param name="providerName">Provider Name</param>
        /// <returns>List of Policy</returns>
        public List<Policy> GetPoliciesByProvider(string providerName)
        {
            throw new NotImplementedException();
        }

        //Don't change this method
        public void Clean()
        {
            this.Policies.DeleteMany(_ => true);
        }
    }
}
