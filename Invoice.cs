using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
   public class Invoice
    {
        [Key]
        public string name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string clothes { get; set; }
        public string clothescost { get; set; }
        public string materialcost { get; set; }
        public string othercost { get; set; }
        public string totalbill { get; set; }
        public string advancepaid { get; set; }
        public string amountpayable { get; set; }
    }
}
