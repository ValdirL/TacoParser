using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }
        // TODO: Complete - "line" represents input data we will Parse to
        //       extract the Longitude.  Your .csv file will have many of these lines,
        //       each representing a TacoBell location

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            //Arrange
            TacoParser newTest = new TacoParser();

            //Act
            var test = newTest.Parse(line);

            //Assert
            Assert.Equal(expected, test.Location.Longitude);
        }

        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {           
            //Arrange
            TacoParser newTest = new TacoParser();

            //Act
            var test = newTest.Parse(line);

            //Assert
            Assert.Equal(expected, test.Location.Latitude);
        }
        


        

    }
}
