using Microsoft.Extensions.Logging;
using Moq;
using Exploring_Actions.Controllers;
using Exploring_Actions;

namespace WeatherForecastControllerTestt
{
    public class UnitTest1
    {
        [Fact]
        public void Test_WeatherForcastController()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);
            
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
        }
    }
}