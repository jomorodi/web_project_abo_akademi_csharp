
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace backend.Controllers;

public class ShopController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "Welcome to the shop page";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // GET: /HelloWorld/Welcome/ 
// Requires using System.Text.Encodings.Web;
public string Welcome(string name, int numTimes= 1)
{
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
}
}