using Microsoft.AspNetCore.Mvc;

/// <summary>
/// 主页
/// </summary>
public class HomeController : ControllerBase {
    public ActionResult Index () {
        return Redirect ("~/swagger/");
    }
}