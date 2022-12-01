using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeePayrollusingMVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Basic pay")]
        public double BasicPay { get; set; }
        [DisplayName("Start Date")]
        public DateTime Start_Date { get; set; }
        public string Address { get; set; }
        //[Range(1,1,ErrorMessage ="Enter one character only M or F")]
        public char Gender { get; set; }
        //[Range(0,10,ErrorMessage ="Phone number take upto 10 digits")]
        public long Phone { get; set; }
        
        public string Department { get; set; }
        public double Deductions { get; set; }
        public double Taxable { get; set; }
        [DisplayName("Income tax")]
        public double IncomeTax { get; set; }
        [DisplayName("Net pay")]
        public double NetPay { get; set; }
    }
}
