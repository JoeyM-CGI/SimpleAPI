using Xunit;
using SimpleAPI.Controllers;
using System;
 

namespace SimpleAPI.Test;

public class UnitTest1
{
   WeatherForecastController controller = new WeatherForecastController();

   [Fact]
   public void GetReturnsWeather()
   {
       var returnValue = controller.Get(1);
        Assert.Equal("This is the wrong value", returnValue.Value);
   }     

    [Fact]
    public void Test1()
    {

    }
}