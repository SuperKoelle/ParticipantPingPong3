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
        public void ParticipantsNameCanBeNull()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = null;

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }
        [Fact]
        public void ParticipantsNameCanBeEmpty()
        {
            // Arrange
            var sut = new Participant();
            string positiveResult = string.Empty;

            // Act
            sut.Name = positiveResult;

            // Assert
            sut.Name.Should().Be(positiveResult);
        }
    }
}
