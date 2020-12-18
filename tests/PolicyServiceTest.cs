using NUnit.Framework;
using InsurancePolicy.Service;
using InsurancePolicy.Entities;

namespace tests
{
    public class PolicyServiceTest
    {
        PolicyService service;
        [OneTimeSetUp]
        public void Setup()
        {
            service = new PolicyService();
        }

        [Test, Order(1)]
        public void AddPolicyShouldSuccess()
        {
            string providerName = "icici";
            string policyName = "iterm";
            Policy policy = new Policy { PolicyName = policyName, PolicyType = "term plan", WebsiteUrl = "iciciprudential.com" };
            service.AddPolicy(providerName, policy).Wait();

            var r1 = service.GetInterestedUser(policyName);
            Assert.Null(r1);
            var r2 = service.GetNumberOfInterestsForAPolicy(policyName);
            Assert.NotNull(r2);
            var r3 = service.GetPolicies(providerName);
            var _policy = r3.Find(p => p.PolicyName == policyName);
            Assert.NotNull(_policy);
        }

        [Test, Order(2)]
        public void AddInterestShouldSuccess()
        {
            string providerName = "icici";
            string policyName = "iterm";
            string email = "mukesh.goel@niit.com";
            service.AddInterest(providerName, policyName, email);

            var r1 = service.GetInterestedUser(policyName);
            Assert.NotNull(r1);
            Assert.AreEqual(1, r1.Count);

            var r2 = service.GetNumberOfInterestsForAPolicy(policyName);
            Assert.NotNull(r2);
            Assert.AreEqual(1, r2.Value);

            var r3 = service.GetInterests(policyName);
            Assert.NotNull(r3);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            service.Clean("iterm");
        }
    }
}