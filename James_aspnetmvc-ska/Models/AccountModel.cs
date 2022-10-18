using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace James_aspnetmvc_ska.Models;

public class AccountModel

{
    [DefaultValue(null)]
    [Required(ErrorMessage = "Necessary data!")]
    [Range(0,100, ErrorMessage = "Range only from 0 to 100")]
    public int Amount { get; set; }
    
    [DefaultValue(null)]
    [Required(ErrorMessage = "Necessary data!")]
    [MaxLength(5, ErrorMessage = "Too long")]
    public string Remark { get; set; }
    
    
    [Required(ErrorMessage = "Necessary data!")]
    [DefaultValue(null)]
    public string CreateTime { get; set; }
}