namespace InsurancePolicy.Entities
{
    /// <summary>
    /// This class is used to define the model for InterestInfo.
    /// This model will be used in Cassandra and should map to a table named as "PolicyInterest".
    /// This class should define the following properties:
    /// 1. PolicyName - string (PartitionKey)
    /// 2. ProviderName - string
    /// 3. EmailId - string (Email id of the user)
    /// 4. InterestShownDate - DateTime
    /// </summary>
    public class InterestInfo
    {
       
    }
}
