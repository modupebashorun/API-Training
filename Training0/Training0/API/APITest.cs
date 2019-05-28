using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Training0.API
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void APITestMethod1()
        {
            var client = new RestClient("http://jsonplaceholder.typicode.com/posts/1");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("cookie", "__cfduid=dc2e0e0815235b77305f2c1ba31c53e5a1558653273");
            request.AddHeader("Host", "jsonplaceholder.typicode.com");
            request.AddHeader("Postman-Token", "f38c3d24-13cc-414f-9c9f-25a2d30e9506,d629d584-b135-4543-87dc-123e7c0037a0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.13.0");
            IRestResponse response = client.Execute(request);

            string status = response.StatusCode.ToString();
            //string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual("OK", status);
         
        
      
          
                
                
                
                
                
                





        }
    }
}
