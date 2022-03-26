using FluentAssertions;
using MarsRover;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class MarsRoverTests
    {
            [Theory]
            [InlineData("5")]
            [InlineData("222")]
            [InlineData("33")]
            [InlineData("5 2")]
            [InlineData("5 5")]
            public void MarsRoverCreate(string input)
            {
                // Arrange
                var expectedCountOfNumber = 2;
                var expectedInputs = typeof(int);

                // Act
                var count = input.Split(' ').Length;
                var inputs = input.Split(' ');

                // Assert
                count.Should().Be(expectedCountOfNumber);
                foreach (var item in inputs)
                {
                    Int32.Parse(item).Should().BePositive();
                }
            }

            [Theory]
            [InlineData("5 5")]
            [InlineData("5 5 2")]
            [InlineData("2 2 E")]
            [InlineData("0 -5 E")]
            [InlineData("5 5 N")]
            public void RoverInitCommand(string input)
            {
                // Arrange
                MarsRover marsRover = new MarsRover(10, 10);
                MarsRover marsRoverExpected = new MarsRover(10, 10);
                marsRoverExpected.Init(5, 5, 'N');

                // Act
                var inputs = input.Split(' ');
                marsRover.Init(Int32.Parse(inputs[0].ToString()), Int32.Parse(inputs[1].ToString()), Char.Parse(inputs[2]));

                // Assert
                marsRover.GetCurrentInfo().Should().Be(marsRoverExpected.GetCurrentInfo());
            }

            [Theory]
            [InlineData("LLLLLLK")]
            [InlineData("MMMS")]
            [InlineData("LMLMLMLMM")]
            public void RoverCommand(string input)
            {
                // Arrange
                MarsRover marsRover = new MarsRover(5, 5);
                marsRover.Init(1, 2, 'N');
                string expectedOutput = "1 3 N";

                // Act
                marsRover.Execute(input);

                // Assert
                marsRover.GetCurrentInfo().Should().Be(expectedOutput);
            }
    }
}
