using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Try.Models;

namespace Try.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    #region viewRegisterPage
    //****************************************
    //To display the viewRegisterPage
    //****************************************
        public IActionResult viewRegisterPage()
        {
                return View("Register");
        }
    #endregion


    #region ChangeLanguage
    //****************************************
    // Changes the culture/language for the current request.
    //@param culture : The culture code (e.g., "en-US") to set for the current request.
    //@param returnUrl : The URL to redirect to after changing the culture.
    //@return : Redirects to the specified returnUrl with the new culture applied.
    //****************************************
        public IActionResult ChangeLanguage(string culture, string returnUrl)
        {
            try
            {   
                if (string.IsNullOrEmpty(culture))
                {
                    throw new ArgumentException("Culture cannot be null or empty", nameof(culture));
                }
                    Response.Cookies.Append
                    (
                        CookieRequestCultureProvider.DefaultCookieName,
                        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture))
                    );
                return LocalRedirect(returnUrl);
            }catch(InvalidOperationException){
                return StatusCode(StatusCodes.Status500InternalServerError, "Response has already started.");
            }catch(Exception){
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while changing language.");
            }
        }
    #endregion

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
