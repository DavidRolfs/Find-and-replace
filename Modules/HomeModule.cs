using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace FindAndReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Object newObject = new Object(Request.Form["sentence"], Request.Form["word"], Request.Form["replace"]);
        return View["result.cshtml", newObject];
      };
    }
  }
}
