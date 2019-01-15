using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    public class BankingUser
    {
        //public string __invalid_name__$id { get; set; }
        public List<object> Banking_BankAccount { get; set; }
        public List<object> Banking_PayService { get; set; }
        public List<object> Banking_Transfer { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
