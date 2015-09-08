using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [ServiceContract(Name= "RESTDemoServices")]
    public interface IWebServicesServer
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "GetContactByPhoneNumber", BodyStyle = WebMessageBodyStyle.Bare, Method= "POST", ResponseFormat= WebMessageFormat.Json)]
        ResponseContact GetContactByPhoneNumber(PhoneNumberRequest req);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetAccountByPhoneNumber", BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        ResponseAccount GetAccountByPhoneNumber(PhoneNumberRequest req);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetAccountByAccountNumber", BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        ResponseAccount GetAccountByAccountNumber(AccountNumberRequest req);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetAccountByContactId", BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        ResponseAccount GetAccountByContactId(ContactIdRequest cidr);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetMostRecentOpenCaseByContactId", BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        ResponseCase GetMostRecentOpenCaseByContactId(ContactIdRequest cidr);
    }
}
