using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inin.Bridge.WebServices.Datadip.Lib
{

    public interface IWebServicesServer
    {
        ResponseContact GetContactByPhoneNumber(PhoneNumberRequest req);

        ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req);

        ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req);

        ResponseAccount GetAccountByContactId(ContactIdRequest cidr);

        ResponseCase GetMostRecentOpenCaseByContactId(ContactIdRequest cidr);
    }
}
