using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.AppUserDTOs
{
    public class AppUserRegisterDTO
    {

        
        public string Name { get; set; }

       
        public string Surname { get; set; }

      
        public string Username { get; set; }

      
        public string Mail { get; set; }

       
        public string Password { get; set; }

        //[Required(ErrorMessage = "Lütfen cep telefonu numaranızı giriniz")]
        //public string Phone { get; set; }

        
        public string ConfirmPassword { get; set; }
    }
}
