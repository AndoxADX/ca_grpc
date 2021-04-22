using clean_architecture_grpc.Domain.Exceptions;
using clean_architecture_grpc.Domain.ValueObjects;
using FluentAssertions;
using NUnit.Framework;

namespace clean_architecture_grpc.Domain.UnitTests.ValueObjects
{
    public class ColourTests
    {
        [Test]
        public void ShouldReturnCorrectColourCode()
        {
            var code = "#FFFFFF";

            var colour = Colour.From(code);

            colour.Code.Should().Be(code);
        }

        [Test]
        public void ToStringReturnsCode()
        {
            var colour = Colour.White;

            colour.ToString().Should().Be(colour.Code);
        }

        [Test]
        public void ShouldPerformImplicitConversionToColourCodeString()
        {
            string code = Colour.White;

            code.Should().Be("#FFFFFF");
        }

        [Test]
        public void ShouldPerformExplicitConversionGivenSupportedColourCode()
        {
            var colour = (Colour)"#FFFFFF";

            colour.Should().Be(Colour.White);
        }

        [Test]
        public void ShouldThrowUnsupportedColourExceptionGivenNotSupportedColourCode()
        {
            FluentActions.Invoking(() => Colour.From("##FF33CC"))
                .Should().Throw<UnsupportedColourException>();
        }
    }
}
