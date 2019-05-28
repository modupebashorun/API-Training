using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Training0.Step_Definitions
{
    [Binding]
    public class APITestWithSpecFlowSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have my End point")]
        public void GivenIHaveMyEndPoint()
        {
           client = new RestClient("https://github.com/typicode/jsonplaceholder/1");
        }
        
        [Given(@"I sent a ""(.*)""")]
        public void GivenISentA(string p0)
        {
           request = new RestRequest(Method.GET);
        }
        
        [When(@"I execute the respose")]
        public void WhenIExecuteTheRespose()
        {
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("cookie", "_octo=GH1.1.23081216.1558657745; logged_in=no; _gh_sess=WXNINnRrbjV5VWRkM2o5R21TVTBXSk9uOUl4bmljVTVJYjhpL0NHTkthUHllaHJiT1JlMGdkK1lRUmE5aWVOeWFqUTVqYjhKT0c3QjJlb3FBazdXWkJXd3FOSnk0d0ZEd25sbE5EU0ZCcTNSNngzRnNMTjN1YUdjdkZHYzkvdG1XYlVpbVAxWnZlbTA0cjBlTXplZkRYbVBwTkN1b1V4T1hrRUl5NjNvWjNjb21qajZUd2xyemlTd3BSMUY0TUhtMW1pSSs1TmIyOGM1cUNvY05nYTY0cVZaaWJ4RVpqNGVtaHBGem1NbTN3bGNIKzZ5QzBlclJSNkJ5OUJJRUxYb2QwazVBaExJRmpQcjh1RDNEN1VlN2JXNnhmR3dicHErK1RnOExFU1hOUUk9LS1YN1ZXbkJxNllnWUdpbUl5RUxVNUVnPT0%3D--088dccb131196858e4ad32bcfb1c53c48c186aa9; has_recent_activity=1");
            request.AddHeader("Host", "github.com");
            request.AddHeader("Postman-Token", "8f364f27-49ea-4d54-b737-37ad983df37b,3c4d5aed-b5a9-4bb5-80fe-7a0cb03808a7");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.13.0");
            response = client.Execute(request);
        }
        
        [Then(@"the response is successful")]
        public void ThenTheResponseIsSuccessful()
        {
            string status = response.StatusCode.ToString();
            //string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual("OK", status);
          
        }
    }
}
