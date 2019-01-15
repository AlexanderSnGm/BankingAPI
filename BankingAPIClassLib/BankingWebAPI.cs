using BankingAPI;
using BankingAPI.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPI
{
    public class BankingWebAPI
    {

        BankingBusinessLogic logic = new BankingBusinessLogic();
        string APIBaseUrl = "";
        public enum Methods {GET,POST,DELETE,PUT};

        public BankingWebAPI() {
            APIBaseUrl = Properties.Settings.Default.APIURL;
#if DEBUG
            //LoginWebMethod("alex@mail.com", "test");
#endif
        }


        #region AUTH
        /// <summary>
        /// Registers a new customer
        /// </summary>
        /// <param name="user">BankingUser Object</param>
        /// <returns>ResultRequest Object</returns>
        public RequestResult RegisterWebMethod(BankingUserReg user){
            string URL = APIBaseUrl + Properties.Settings.Default.RegisterMethod;
            RequestResult result = new RequestResult();
            string json = logic.POST(URL, JsonConvert.SerializeObject(user));
            result.BankingUserResult = JsonConvert.DeserializeObject<BankingUser>(json);
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        /// <summary>
        /// Validates a new customer
        /// </summary>
        /// <param name="user">BankingUser Object</param>
        /// <returns>ResultRequest Object</returns>
        public RequestResult LoginWebMethod(string email, string password)
        {

            string URL = APIBaseUrl + Properties.Settings.Default.LoginMethod;
            RequestResult result = new RequestResult();
            string json = logic.POST(URL, "{\"Email\": \""+email+"\",  \"Password\": \""+password+"\"}");
            result.BankingUserResult = JsonConvert.DeserializeObject<BankingUser>(json);
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion


        #region BankAccount

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public RequestResult BankAccountWebMethod(Methods methodToUse, BankingBankAccount bba = null)
        {
            RequestResult result = new RequestResult();
            string URL = "";
            string json = "";
            URL = APIBaseUrl + Properties.Settings.Default.BankAccount;
            switch (methodToUse)
            {
                case Methods.GET:
                    if (bba != null)
                    {
                        URL  += "/" + bba.Id;
                        json = logic.GET(URL);
                        result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    }
                    else
                    {
                        json = logic.GET(URL);
                    }
                    
                    break;
                case Methods.POST:
                    json = logic.POST(URL, JsonConvert.SerializeObject(bba));
                    result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    break;
                case Methods.DELETE:
                    URL += "/" + bba.Id;
                    json = logic.DELETE(URL);
                    break;
                case Methods.PUT:
                    URL += "/" + bba.Id;
                    json = logic.PUT(URL, JsonConvert.SerializeObject(bba));
                    break;
                default:
                    break;
            }
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion

        #region PayService
        public RequestResult PayServiceWebMethod(Methods methodToUse, BankingPayService bps = null)
        {

            RequestResult result = new RequestResult();
            string URL = APIBaseUrl + Properties.Settings.Default.PayService;
            string json = "";
            switch (methodToUse)
            {
                case Methods.GET:
                    if (bps != null)
                    {
                        URL += "/" + bps.Id;
                        json = logic.GET(URL);
                        result.BankingPayServiceResult = JsonConvert.DeserializeObject<BankingPayService>(json);
                    }
                    else
                    {
                        json = logic.GET(URL);
                    }

                    break;
                case Methods.POST:
                    json = logic.POST(URL, JsonConvert.SerializeObject(bps));
                    result.BankingPayServiceResult = JsonConvert.DeserializeObject<BankingPayService>(json);
                    break;
                case Methods.DELETE:
                    URL += "/" + bps.Id;
                    json = logic.DELETE(URL);
                    break;
                case Methods.PUT:
                    URL +=  "/" + bps.Id;
                    json = logic.PUT(URL, JsonConvert.SerializeObject(bps));
                    break;
                default:
                    break;
            }
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion

        #region Service
        public RequestResult ServiceWebMethod(Methods methodToUse, BankingService bs = null)
        {

            RequestResult result = new RequestResult();
            string URL = APIBaseUrl + Properties.Settings.Default.Service;
            string json = "";
            switch (methodToUse)
            {
                case Methods.GET:
                    if (bs != null)
                    {
                        URL +=  "/" + bs.Id;
                        json = logic.GET(URL);
                        result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    }
                    else
                    {
                        json = logic.GET(URL);
                    }

                    break;
                case Methods.POST:
                    json = logic.POST(URL, JsonConvert.SerializeObject(bs));
                    result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    break;
                case Methods.DELETE:
                    URL +=  "/" + bs.Id;
                    json = logic.DELETE(URL);
                    break;
                case Methods.PUT:
                    URL +=  "/" + bs.Id;
                    json = logic.PUT(URL, JsonConvert.SerializeObject(bs));
                    break;
                default:
                    break;
            }
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion

        #region Transfer
        public RequestResult TransferWebMethod(Methods methodToUse, BankingTransfer bt = null)
        {

            RequestResult result = new RequestResult();
            string URL = APIBaseUrl + Properties.Settings.Default.Transfer;
            string json = "";
            switch (methodToUse)
            {
                case Methods.GET:
                    if (bt != null)
                    {
                        URL +=  "/" + bt.Id;
                        json = logic.GET(URL);
                        result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    }
                    else
                    {
                        json = logic.GET(URL);
                    }

                    break;
                case Methods.POST:
                    json = logic.POST(URL, JsonConvert.SerializeObject(bt));
                    result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    break;
                case Methods.DELETE:
                    URL +=  "/" + bt.Id;
                    json = logic.DELETE(URL);
                    break;
                case Methods.PUT:
                    URL +=  "/" + bt.Id;
                    json = logic.PUT(URL, JsonConvert.SerializeObject(bt));
                    break;
                default:
                    break;
            }
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion

        #region User
        public RequestResult UserWebMethod(Methods methodToUse, BankingUser bu = null)
        {

            RequestResult result = new RequestResult();
            string URL = APIBaseUrl + Properties.Settings.Default.User;
            string json = "";
            switch (methodToUse)
            {
                case Methods.GET:
                    if (bu != null)
                    {
                        URL +=  "/" + bu.Id;
                        json = logic.GET(URL);
                        result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    }
                    else
                    {
                        json = logic.GET(URL);
                    }

                    break;
                case Methods.POST:
                    json = logic.POST(URL, JsonConvert.SerializeObject(bu));
                    result.BankingBankAccountResult = JsonConvert.DeserializeObject<BankingBankAccount>(json);
                    break;
                case Methods.DELETE:
                    URL +=  "/" + bu.Id;
                    json = logic.DELETE(URL);
                    break;
                case Methods.PUT:
                    URL +=  "/" + bu.Id;
                    json = logic.PUT(URL, JsonConvert.SerializeObject(bu));
                    break;
                default:
                    break;
            }
            result.Status = 0;
            result.Result = "200 OK";
            return result;
        }

        #endregion

    }
}
