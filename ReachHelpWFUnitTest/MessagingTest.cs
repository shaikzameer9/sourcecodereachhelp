using System;
using Xunit;
using ReachHelpWF.Models;

namespace ReachHelpWFUnitTest
{
    
    public class MessagingTest
    {
        [Theory]
        [InlineData("Test Message", "9611703294", true)]
        [InlineData("Test Message", "9632940020", true)]
        public void CheckTriggerSMS(string messageContent, string mobileNumber,bool expected)
        {
            MessagingModel sendSms = new MessagingModel();
           bool actual =  sendSms.TriggerSMS(messageContent, mobileNumber);
           Assert.Equal(expected, actual);
        }
    }
}
