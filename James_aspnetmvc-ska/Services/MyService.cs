using System.Text.Json;
using James_aspnetmvc_ska.Models;
namespace James_aspnetmvc_ska.Services;
public class MyService
{
    // TODO: Get/Store Data
    private List<AccountModel> dataList = new List<AccountModel>();

    public string GetDataByJson()
    {
        var serialData = "";
        foreach (AccountModel data in dataList)
        {
            serialData += JsonSerializer.Serialize(data);
        }
        return serialData;
    }

    public List<AccountModel> GetData()
    {
        return dataList;
    }
    public List<AccountModel> AddData(AccountModel data)
    {
        dataList.Add(data);
        return GetData();
    }
}