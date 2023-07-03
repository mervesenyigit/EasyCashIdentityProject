using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }

        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
//ıd isle türü(gelen ,giden,ödeme)-miktar-tarih tamam fakat alıcı ve gönderici de olmalı bun apuserdan alamyacakmısız.