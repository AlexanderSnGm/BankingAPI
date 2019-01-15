using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPI.Objects
{
    public class RequestResult
    {
        public int Status{ get; set; }
        public string Result { get; set; }
        public BankingBankAccount BankingBankAccountResult{ get; set; }
        public BankingCidInformation BankingCidInformationResult { get; set; }
        public BankingPayService BankingPayServiceResult { get; set; }
        public BankingService BankingServiceResult { get; set; }
        public BankingTransfer BankingTransferResult { get; set; }
        public BankingUser BankingUserResult { get; set; }

        public RequestResult() {
            Status = -1;
            Result = "";
        }
    }
}
