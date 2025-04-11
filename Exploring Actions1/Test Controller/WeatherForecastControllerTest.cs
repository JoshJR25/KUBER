using Exploring_Actions1;
using Exploring_Actions1.Controllers;
using Microsoft.Extensions.Logging;
using Moq;


namespace Test_Controller
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Test_WeatherRorecastController()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            var result = controller.Get();

            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);

        }
    }
}