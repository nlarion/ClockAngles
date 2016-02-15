using Xunit;
using System;
using System.Collections.Generic;

namespace ClockAngle
{
  // public class TranslatorTest : IDisposable
  public class ClockTest
  {
    [Fact]
    public void OneTestToPassThemAll()
    {
      //Arrange
      int userHour = 12;
      int userMin = 59;
      //Act
      var newClock = new Clock(userHour, userMin);
      //Assert
      Assert.Equal(30, newClock.ReturnDegrees());
    }
    [Fact]
    public void OneTestToPassThemAllKinda()
    {
      //Arrange
      int userHour = 6;
      int userMin = 0;
      //Act
      var newClock = new Clock(userHour, userMin);
      //Assert
      Assert.Equal(180, newClock.ReturnDegrees());
    }
  }
}
