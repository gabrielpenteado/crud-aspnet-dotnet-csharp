using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace api_aspnet_dotnet_csharp.Models;

public class Student
{

  [Key]
  [DisplayName("ID")]
  public int ID { get; set; }

  [Required(ErrorMessage = "Type the student name.")]
  [StringLength(80, ErrorMessage = "The name should have a maximum of 80 characters.")]
  [MinLength(5, ErrorMessage = "The name should have at least 5 characters.")]
  [DisplayName("Name")]
  public string Name { get; set; } = string.Empty;

  [Required(ErrorMessage = "Type the student email.")]
  [EmailAddress(ErrorMessage = "Invalid email.")]
  [DisplayName("Email")]
  public string Email { get; set; } = string.Empty;

  public List<Subscription> Subscriptions { get; set; } = new();


}