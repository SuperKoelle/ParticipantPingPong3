using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
        [Trait("Category", "City")]
        public void ParticipantsCitySymbols()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#¤%";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.City = positiveResult);
        }
        [Fact]
        [Trait("Category", "City")]
        public void ParticipantsCityValid()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Vejle";

            // Act
            sut.City = positiveResult;

            // Assert
            sut.City.Should().Be(positiveResult);
        }
        [Fact]
        [Trait("Category", "Name")]
        public void ParticipantsNameValid()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "Jens";

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }
        [Fact]
        [Trait("Category", "Name")]
        public void ParticipantsNameMustNoteNull()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = null;


            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Fact]
        [Trait("Category", "Name")]

        public void ParticipantsNameMustNotBeEmpty()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Fact]
        [Trait("Category", "Name")]

        public void ParticipantNameThrowsExceptionIfContainsDigits()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = "Jens 1";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Trait("Category", "Name")]

        public void ParticipantNameThrowsExceptionIfContainsSymbols()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = "Jens #";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }

        [Theory]
        [InlineData("Navn", "Navn")]
        [InlineData("navn", "Navn")]
        [InlineData("nAvn", "Navn")]
        [InlineData("Navn Mellemnavn", "Navn Mellemnavn")]
        [InlineData("navn mellemnavn", "Navn Mellemnavn")]
        [InlineData("navn-mellemnavn", "Navn-Mellemnavn")]
        [InlineData("NAVN", "Navn")]
        [InlineData("NAVN MELLEMNAVN", "Navn Mellemnavn")]
        [InlineData("NAVN-MELLEMNAVN", "Navn-Mellemnavn")]
        [InlineData("NAVN-MELLEMNAVN", "Navn-Mellemnavn")]
        [Trait("Category", "Name")]
        public void ParticipantNameFirstCharcterChangeToUpper(string testName, string expecedResult)
        {
            // Arrange
            var sut = new Participant();

            // Act
            sut.Name = testName;

            // Assert
            Assert.Equal(sut.Name,expecedResult);
        }


    }
}
