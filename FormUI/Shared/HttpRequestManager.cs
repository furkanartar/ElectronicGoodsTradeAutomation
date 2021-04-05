using RestSharp;

namespace FormUI.Shared
{
    public class HttpRequestManager : IHttpRequestService
    {
        private string _apiUrl = "https://localhost:44394/api/";
        public IRestResponse GetRequest(string adress)
        {
            var newUrl = _apiUrl + adress;
            var client = new RestClient(newUrl);
            var request = new RestRequest();
            //request.AddParameter("Authorization", "Bearer " + );
            request.Method = Method.GET;
            var response = client.Get(request);
            return response;
        }

        public IRestResponse GetRequestParameter(string adress, string parameterName, object parameters)
        {
            throw new System.NotImplementedException();
        }

        public IRestResponse PostRequest(string adress, string token)
        {
            var newUrl = _apiUrl + adress;
            var client = new RestClient(newUrl);
            var request = new RestRequest();
            request.AddParameter("Authorization", "Bearer " + token);
            var response = client.Post(request);

            return response;
        }
    }
}