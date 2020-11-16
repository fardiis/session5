using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UserViewModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "نام  الزامیست")]
        public string Name { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "نام خانوادگی الزامیست")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "شماره نلفن الزامیست")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "شماره نلفن الزامیست")]
        [RegularExpression(@"09[1 9 3 0]\d{8}", ErrorMessage = "شماره نامعتبر است")]
        public int Mobile { get; set; }
        public int codeMeli { get; set; }
        public int CodePosti { get; set; }
        public int ShomareShenasname { get; set; }
        public string Address { get; set; }
        public IEnumerable<string> Karbar { set; get; } = new List<string>
        {
        "طلایی","نقره ای ","برنزی"

        };
        public int SelectedStatus { set; get; }

        public IEnumerable<string> Status { set; get; } = new List<string>
        {
        "حقیقی","حقوقی "

        };
       
        public string CompanyName { get; set; }
        public int CopanyCode { set; get; }
        public int EconomyCode { set; get; }


        public IEnumerable<string> Ashnaee { set; get; } = new List<string>
        {
        "معرفی دوستان","تبلیغات "

        };
        public int SelectedKnown { set; get; }
        public string CaptchaCode { get; set; }

    }
}
