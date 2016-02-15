using Nancy;
using System.Collections.Generic;

namespace ClockAngle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Clock newClock = new Clock(Request.Form["hours"], Request.Form["min"]);
        return View["index.cshtml",newClock.ReturnDegrees()];
      };
    }
  }
}
