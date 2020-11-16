using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Demo.DAL
{
    public class RegisterContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;intial catalog=Register;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public int Mobile { get; set; }
        public int codeMeli { get; set; }
        public int CodePosti { get; set; }
        public int ShomareShenasname { get; set; }
        public string Address { get; set; }
        public IEnumerable<string> Karbar { set; get; } = new List<string>
        {
        "طلایی","نقره ای "

        };
        public int SelectedGender { set; get; }

        public IEnumerable<string> Status { set; get; } = new List<string>
        {
        "حقیقی","حقوقی "

        };
        public int SelectedStatus { set; get; }
        public string CompanyName { get; set; }
        public int CopanyCode { set; get; }
        public int EconomyCode { set; get; }


        public IEnumerable<string> Ashnaee { set; get; } = new List<string>
        {
        "معرفی دوستان","تبلیغات "

        };
        public int SelectedKnown { set; get; }



    }
}
