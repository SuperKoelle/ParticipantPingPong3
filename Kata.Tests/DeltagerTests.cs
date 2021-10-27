using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class ParticipantsTests
    {
        [Fact]
        public void ParticipantsCitySymbols()
        {
            // Arrange
            var sut = new Participant();
            var positiveResult = "#¤%";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.City = positiveResult);
        }
        [Fact]
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
        public void ParticipantsNameMustNoteNull()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = null;


            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Fact]
        public void ParticipantsNameMustNotBeEmpty()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Fact]
        public void ParticipantNameThrowsExceptionIfContainsDigits()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = "Jens 1";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
        [Fact]
        public void ParticipantNameThrowsExceptionIfContainsSymbols()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = "Jens #";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.Name = positiveResult);
        }
    }
}
