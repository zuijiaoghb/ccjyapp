using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ccjyapp.Data ;

[Index(nameof(SerialNumber), IsUnique = true)]
public class MotorParameterModel
{

  public MotorParameterModel() {}

  public MotorParameterModel(DateTime addtime , DateTime modifytime) {
        this.AddTime = addtime;
        this.ModifyTime = modifytime;
   }

   public int Id { get; set; }
   
   [Required]
   public MotorParameterCompany Company { get; set; }

   [Required]
   [Comment("中联编码")]
   [StringLength(10,
        ErrorMessage = "中联编码长度最长为10位")]   
   public string ZLCode { get; set; }
   
    [Required]  
    [StringLength(11,
        ErrorMessage = "序列号长度最长为11位")]     
    public string SerialNumber { get; set; }
    
    [Required]    
    public double RatedPower { get; set; }
	
    [Required]    
    public double RatedFrequency { get; set; }

    [Required]    
    public double RatedSpeed { get; set; }

    [Required]    
    public double RatedVoltage { get; set; }

    [Required]    
    public double RatedCurrent { get; set; }

    [Required]    
    public double StatorResistance { get; set; }

    [Required]    
    public double RotorResistance { get; set; }

    [Required]    
    public double LeakageReactance { get; set; }

    [Required]    
    public double MutualInductance { get; set; }

    [Required]    
    public double NoLoadCurrent { get; set; }

    public bool Selected { get; set; }

    // user ID from AspNetUser table.
    public string? OwnerID { get; set; }

    [Required]
    public MotorParameterStatus Status { get; set; }    

    [Required]
    public DateTime AddTime { get; set; }

    public DateTime? ModifyTime { get; set; }


    /*
    [Range(1, 100000,
        ErrorMessage = "Accommodation invalid (1-100000).")]
    public int MaximumAccommodation { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
    public bool IsValidatedDesign { get; set; }

    [Required]
    public DateTime ProductionDate { get; set; }
    */
}

public enum MotorParameterStatus
{
    Submitted,
    Approved,
    Rejected
}

public enum MotorParameterCompany
{
   江特电机,
   江西江特,
   银锂新能源,
   杭州米格,
   天津华兴,
   宜丰锂业,
   泰昌矿业,
   江特电动车,
   江特客车厂,
   尉尔江西电机有限公司,
   江特高新装备公司,
   江特高新武汉分公司
}
