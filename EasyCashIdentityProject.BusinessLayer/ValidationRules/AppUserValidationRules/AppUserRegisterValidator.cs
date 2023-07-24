
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
        //bu raya AppUSER yazmammız sağlıklı olmaz kullanmayacağımız properyler var.
    {
        //ben burada Rulefor'a erişim sağlayamıyorum. yapıcı metottla geliyor
        public AppUserRegisterValidator()
        {
            
        }
    }
}
