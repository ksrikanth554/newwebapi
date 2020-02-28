using System.ComponentModel.DataAnnotations;

namespace newwebapi.Models{

    public class Company{
        [Key]
        public string CompanyName{get;set;}
        public int number{get;set;}

    }

}
