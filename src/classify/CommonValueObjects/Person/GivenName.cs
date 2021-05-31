namespace Classify.CommonValueObjects.Person
{
    using Classify.BaseValueObjects;
    using Classify.JsonSerialization.Microsoft;

    [System.Text.Json.Serialization.JsonConverter(typeof(SimpleValueObjectConverter))] // Todo - Replace with interface converter when supported.
    public class GivenName : SensitiveValueObject<string>
    {
        public GivenName(string value)
            : base(value, ClassificationTypes.PII) {}
    }
}
