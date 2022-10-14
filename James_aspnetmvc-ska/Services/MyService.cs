using James_aspnetmvc_ska.Models;
using Newtonsoft.Json;

namespace James_aspnetmvc_ska.Services;

public class MyService
{
    // TODO: Get/Store Data
    private readonly List<AccountModel>? dataList= new List<AccountModel>();

    public MyService()
    {
        if (File.Exists("./dataList.json"))
            dataList = JsonConvert.DeserializeObject<List<AccountModel>>(File.ReadAllText("./dataList.json"));
    }

    public List<AccountModel>? GetData()
    {
        return dataList;
    }

    public string GetDataString()
    {
        // for json serialize
        return JsonConvert.SerializeObject(dataList);
    }

    public List<AccountModel>? AddData(AccountModel data)
    {
        dataList.Add(data);
        File.WriteAllText("./dataList.json", GetDataString());
        return GetData();
    }
}