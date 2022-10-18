using James_aspnetmvc_ska.Models;
using James_aspnetmvc_ska.Services;
using Microsoft.AspNetCore.Mvc;

namespace James_aspnetmvc_ska.Controllers;


[Route("[Controller]")]
public class AccountController : Controller
{
    private readonly MyService _myService;
    private readonly ViewAccountModel _viewAccountModel;

    public AccountController(MyService myService, ViewAccountModel viewAccountModel)
    {
        _myService = myService;
        _viewAccountModel = viewAccountModel;
    }


    // GET
    [Route("")]
    public IActionResult Index()
    {
        //ViewData["dataList"] = _myService.GetData();
        _viewAccountModel.AccountModels = _myService.GetData();
        return View(_viewAccountModel);
    }

    [HttpPost]
    [Route("Save")]
    public IActionResult Save(string Remark, int Amount, DateTime CreateTime)
    {
        var status = ModelState.IsValid;
        if (status)
        {
            //ViewData["dataList"] = _myService.GetData();
            _viewAccountModel.AccountModels= _myService.AddData(new AccountModel
            {
                Remark = Remark, Amount = Amount, CreateTime = CreateTime.ToString("MM/dd/yyyy")
            });

        }

        return View("Index",_viewAccountModel);
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