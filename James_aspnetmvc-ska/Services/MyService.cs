using James_aspnetmvc_ska.Models;
using Newtonsoft.Json;

namespace James_aspnetmvc_ska.Services;
public class MyService
{
    // TODO: Get/Store Data
    private List<AccountModel> dataList = new List<AccountModel>();


    public List<AccountModel> GetData()
    {
        return dataList;
    }

    
    public string GetDataString()
    { // for json serialize
        return JsonConvert.SerializeObject(dataList);
    }
    public List<AccountModel> AddData(AccountModel data)
    {
        dataList.Add(data);
        return GetData();
    }
    
}