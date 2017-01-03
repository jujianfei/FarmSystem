/*
 *创建人：琚建飞
 *创建时间：2016/12/7 20:05:24
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Equipment
    {
        public string name { get; set; }
        public string sum { get; set; }
        public string stock { get; set; }
        public string mno { get; set; }
        public string time { get; set; }
    }
    public class LoanRecord
    {
        public string no { get; set; }
        public string name { get; set; }
        public string loanpno { get; set; }
        public string num { get; set; }
        public string time { get; set; }
        public string state { get; set; }
    }
}
