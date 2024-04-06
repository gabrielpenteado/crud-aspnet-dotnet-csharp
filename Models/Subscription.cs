using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace api_aspnet_dotnet_csharp.Models;

public class Subscription
{

  [Key]
  [DisplayName("ID")]
  public int ID { get; set; }

  [Required(ErrorMessage = "Type the subscription title.")]
  [StringLength(80, ErrorMessage = "The title should have a maximum of 80 characters.")]
  [MinLength(5, ErrorMessage = "The title should have at least 5 characters.")]
  [DisplayName("Title")]
  public string Title { get; set; } = string.Empty;

  [DataType(DataType.DateTime)]
  // [GreaterThanToday]
  [DisplayName("Start")]
  public DateTime StartDate { get; set; }

  [DataType(DataType.DateTime)]
  // [GreaterThanToday]
  [DisplayName("End")]
  public DateTime EndDate { get; set; }

  [DisplayName("Student")]
  [Required(ErrorMessage = "Invalid student.")]
  public int StudentID { get; set; }

  public Student? Student { get; set; }
}