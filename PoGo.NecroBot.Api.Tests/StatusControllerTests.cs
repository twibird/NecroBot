using System;
using System.Net;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PoGo.NecroBot.Api.Tests
{
    [TestClass]
    public class StatusControllerTests
    {
        [TestMethod]
        public void StatusIntegrationSuccessTest()
        {
            HttpClient client = new HttpClient();
            
            Assert.AreEqual(client.GetAsync(new Uri("localhost/status")).Result.StatusCode, HttpResponseCode.OK);
        }


    }
}
