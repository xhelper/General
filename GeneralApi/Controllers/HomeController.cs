using Microsoft.AspNetCore.Mvc;

public class HomeController : ControllerBase {

    public ActionResult Index () {
        return Redirect ("~/swagger/");
    }
}