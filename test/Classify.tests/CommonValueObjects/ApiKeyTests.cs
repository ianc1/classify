namespace Classify.tests.CommonValueObjects
{
    using System;
    using Classify.CommonValueObjects;
    using FluentAssertions;
    using Xunit;

    public class ApiKeyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Constructor_should_throw_for_invalid_values(string value)
        {
            Action act = () => new ApiKey(value);

            act.Should().Throw<FormatException>().WithMessage("Must not be empty.");
        }
    }
}