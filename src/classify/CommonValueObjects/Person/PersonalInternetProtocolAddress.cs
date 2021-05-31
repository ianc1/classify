namespace Classify.CommonValueObjects.Person
{
    using Classify.BaseValueObjects;

    [System.Text.Json.Serialization.JsonConverter(typeof(Classify.JsonSerialization.Microsoft.SingleValueObjectConverter))] // Todo - Replace with interface converter when supported.
    public class PersonalInternetProtocolAddress : SensitiveValueObject<string>
    {
        public PersonalInternetProtocolAddress(string value)
            : base(value, ClassificationTypes.PII) {}
    }
}
