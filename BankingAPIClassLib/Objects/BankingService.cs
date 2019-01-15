using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    /// <summary>
    /// Banking Service
    /// </summary>
    public class BankingService
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<BankingPayService> Banking_PayService { get; set; }
    }
}
