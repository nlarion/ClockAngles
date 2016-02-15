using System;
using System.Collections.Generic;

namespace ClockAngle
{
  public class Clock
  {
    private int _hours;
    private int _minutes;

    public Clock(int hours, int minutes)
    {
      _hours = hours;
      _minutes = minutes;
    }

    public double ReturnHours()
    {
      if (_hours == 12) {
        return 0;
      } else {
        return _hours * 30;
      }
    }

    public double ReturnMinutes()
    {
      return Math.Ceiling((double) _minutes / 2);
    }

    public double ReturnDegrees()
    {
      return ReturnHours() + ReturnMinutes();
    }
  }
}
