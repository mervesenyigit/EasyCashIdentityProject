﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int> //burada int yazmamım nedeni kullanıcılar için biriincil anahtar olarak kullalacak değerin türünü böyle yapıyorum.
    {
        //buradaki yerleri dbset te verilmesine gerek yok bunlar zaten mevcut sınıfa property olarak ekledik.
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }

        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
