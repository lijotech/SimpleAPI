using System;
using Xunit;
using  SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMyReturnValue ()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var someService = new WeatherForecastController(mockLogger.Object);

            var returnValue=someService.Fetch(1);
            Assert.Equal("Lijo Sebastian",returnValue.Value);
        }

        [Fact]
        public void Test1()
        {
       

        }
    }
}
