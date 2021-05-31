namespace Classify.CommonValueObjects.Person
{
    using System;
    using Classify.BaseValueObjects;
    using Classify.JsonSerialization.Microsoft;

    [System.Text.Json.Serialization.JsonConverter(typeof(SimpleValueObjectConverter))] // Todo - Replace with interface converter when supported.
    public class DateOfBirth : SensitiveValueObject<DateTimeOffset>
    {
        public DateOfBirth(string value)
            : base(Validate(value), ClassificationTypes.PII) {}

        public override object SerializeObject() => SensitiveValue.ToString("yyyy-MM-dd");

        private static DateTimeOffset Validate(string value)
        {
            if (!DateTimeOffset.TryParse(value, out var date))
            {
                throw new FormatException($"Invalid {nameof(DateOfBirth)} format: {value}");
            }

            return date;
        }
    }
}