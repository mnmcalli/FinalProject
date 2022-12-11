using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly bank db;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Withdraw()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Withdraw(double amount){
      IEnumerable<Account> model = db.Account
        .Include(a => a.balance)
        .AsEnumerable(); // switch to client-side
        double a = amount;
        double b = Balance.get();
        double c = b - a;
        double expected = Balance - amount;
        Debug.Assert(c == Account.withdraw(amount));
      return View(model); // pass model to view
    }
    
}
