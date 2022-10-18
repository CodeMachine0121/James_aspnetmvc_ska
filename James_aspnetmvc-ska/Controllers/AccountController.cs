using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using James_aspnetmvc_ska.Models;
using James_aspnetmvc_ska.Services;

namespace James_aspnetmvc_ska.Controllers;

[Route("[Controller]")]
public class AccountController : Controller
{
    private readonly MyService _myService;

    public AccountController(MyService myService)
    {
        _myService = myService;
    }


    // GET
    [Route("")]
    public IActionResult Index()
    {
        ViewData["dataList"] = _myService.GetData();
        return View();
    }

    [HttpPost]
    [Route("Save")]
    public IActionResult Save(string Remark, int Amount, DateTime CreateTime)
    {
        if (!ModelState.IsValid)
        {
            ViewData["dataList"] = _myService.GetData();
            return View("Index");
        }

        ViewData["dataList"] = _myService.AddData(new AccountModel
        {
            Remark = Remark, Amount = Amount, CreateTime = CreateTime.ToString("MM/dd/yyyy")
        });

        return View("Index");
    }

    [HttpGet]
    [Route("~/api/records")]
    public IActionResult getData()
    {
        var jsonData = _myService.GetDataString();
        ViewBag.records = jsonData;
        return View("records");
    }
}