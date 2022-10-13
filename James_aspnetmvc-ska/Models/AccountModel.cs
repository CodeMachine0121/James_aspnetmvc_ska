using System.ComponentModel.DataAnnotations;

namespace James_aspnetmvc_ska.Models;

public class AccountModel
{
    [Required(ErrorMessage = "Necessary data!")]
    [Range(0,100, ErrorMessage = "Range only from 0 to 100")]
    public int Amount { get; set; }
    
    [Required(ErrorMessage = "Necessary data!")]
    [MaxLength(5, ErrorMessage = "Too long")]
    public string Remark { get; set; }
    
    
    [Required(ErrorMessage = "Necessary data!")]
    [DataType(DataType.DateTime,ErrorMessage = "Error data type")]
    public DateTime CreateTime { get; set; }
}