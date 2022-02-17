using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    public class Records
    {
        [Key]
        public string name { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string length { get; set; }
        public string sleevslength { get; set; }
        public string sleevsbottom { get; set; }
        public string frontneck { get; set; }
        public string hipp { get; set; }
        public string shoulder { get; set; }
        public string waist { get; set; }
        public string hipplength { get; set; }
        public string backneck { get; set; }
        public string waistlength { get; set; }
        public string chest { get; set; }
        public string upperchest { get; set; }
        public string dotpoint { get; set; }
        public string lenght1 { get; set; }
        public string bottom { get; set; }
        public string knee { get; set; }
        public string thighs { get; set; }
        public string waist1 { get; set; }
        public string orders { get; set; }
        public string TOPorBLOUSE { get; set; }
        public string pant { get; set; }
        
    }
}
