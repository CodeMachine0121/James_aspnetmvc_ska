using James_aspnetmvc_ska.Models;
using James_aspnetmvc_ska.Services;
using Microsoft.AspNetCore.Mvc;

namespace James_aspnetmvc_ska.Controllers;


[Route("[Controller]")]
public class AccountController : Controller
{
    private readonly MyService _myService;
    private readonly IndexViewModel _indexViewModel;

    public AccountController(MyService myService, IndexViewModel indexViewModel)
    {
        _myService = myService;
        _indexViewModel = indexViewModel;
    }


    // GET
    [Route("")]
    public IActionResult Index()
    {
        //ViewData["dataList"] = _myService.GetData();
        _indexViewModel.AccountModels = _myService.GetData();
        return View(_indexViewModel);
    }

    [HttpPost]
    [Route("Save")]
    public IActionResult Save(AccountModel accountModel)
    {
        var status = ModelState.IsValid;
        if (status)
        {
            //ViewData["dataList"] = _myService.GetData();
            _indexViewModel.AccountModels = _myService.AddData(accountModel);

        }
        else
            ModelState.AddModelError("","Input Data Error");
        
        return View("Index", _indexViewModel);
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