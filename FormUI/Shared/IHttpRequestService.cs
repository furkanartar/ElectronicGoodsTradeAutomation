using RestSharp;

namespace FormUI.Shared
{
    public interface IHttpRequestService
    {
        IRestResponse GetRequest(string adress);
        IRestResponse GetRequestParameter(string adress, string parameterName, object parameters);
        IRestResponse PostRequest(string adress, string token);
        //IRestResponse PostRequestParameter(string adress);
    }
}