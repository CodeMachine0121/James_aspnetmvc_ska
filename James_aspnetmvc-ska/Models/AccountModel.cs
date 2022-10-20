using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace James_aspnetmvc_ska.Models;

public class AccountModel:ValidationAttribute

{
    [Range(0,10)]
    public int Amount { get; set; }
    
    [DefaultValue(null)]
    [Required(ErrorMessage = "Necessary data!")]
    [MaxLength(5, ErrorMessage = "Too long")]
    public string Remark { get; set; }
    
    
    [Required(ErrorMessage = "Necessary data!")]
    [DefaultValue(null)]
    public string CreateTime { get; set; }
}