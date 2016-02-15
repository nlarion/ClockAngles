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
      int userMin = 0;
      //Act
      var newClock = new Clock(userHour, userMin);
      //Assert
      Assert.Equal(0, newClock.ReturnDegrees);
    }
  }
}
