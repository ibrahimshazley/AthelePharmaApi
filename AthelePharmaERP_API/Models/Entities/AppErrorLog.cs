using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class AppErrorLog
    {
        public decimal RecId { get; set; }
        public string ErrorId { get; set; }
        public string ErrorMessage { get; set; }
        public string UserName { get; set; }
        public DateTime? InsDate { get; set; }
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
    }
}
