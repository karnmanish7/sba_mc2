using System;

namespace InsurancePolicy.DAO
{
    /// <summary>
    /// This class is used to maintain all operations with Azure Cache For Redis
    /// </summary>
    public class CounterRepository
    {
        readonly IDistributedCache cache;
        public CounterRepository()
        {
            
        }

        /// <summary>
        /// This method is used to Add a Key/Value in Redis. Key is intialized with value 0.
        /// </summary>
        /// <param name="policyName">Policy Name as Key</param>
        public void AddPolicy(string policyName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is invoked when a user shows interest in a policy.
        /// It should increment the value by 1.
        /// </summary>
        /// <param name="policyName">Policy Name as Key to identify in Redis</param>
        public void IncreaseCounter(string policyName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to fetch total no of interests shown for a policy.
        /// </summary>
        /// <param name="policyName">Policy Name as Key to identify in Redis</param>
        /// <returns>Number of Interests or null</returns>
        public int? GetInterestsForAPolicy(string policyName)
        {
            throw new NotImplementedException();
        }

        //Don't change this method
        public void Clean(string key)
        {
            cache.Remove(key);
        }
    }
}
