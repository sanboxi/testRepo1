using RestSharp;
using System;
using System.Text;

namespace RestClient_Latest
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalUrl = "";
            var client = new RestClient(finalUrl);
            var request = new RestRequest(Method.GET);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("ContentType", "application/json");
            var userName = "";
            var passWord = "";//stg
            //var passWord = "P7NUr8HphL5LK646zafF";//prod
            var credential = System.Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userName}:{passWord}"));
            var bytes = Encoding.UTF8.GetBytes($"{userName}:{passWord}");
            request.AddHeader("Authorization", $"Basic {credential}");

            try
            {
                var response = client.Execute(request);

                if (response == null)
                {
                    

                    
                }
                
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}
