using System;
using System.Linq;
using Xunit;
using ReachHelpWF.Models;
using System.Collections.Generic;

namespace ReachHelpWFUnitTest
{
    public class UserModelTest
    {
        //[Theory]
        //[InlineData("Vikram", "9611703294", "test", "1", "", "", "Manipal","1","17","120","576104","","",true)]
        //public void CheckRegisterUser(string userName, string phoneNumber, string password, string roleId, string entityName, string designation, string address, string countryId, string stateId, string cityId, string pincode, string latitude, string longitude,bool expected)
        //{
        //    UserModel userDetails = new UserModel(userName, phoneNumber, password, roleId, entityName, designation, address, countryId, stateId, cityId, pincode, latitude, longitude);
        //    bool actual = userDetails.RegisterUser(userDetails);
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("1", "Active", true)]
        //[InlineData("2", "Active", false)]
        //public void CheckStatusChange(string userId, string status, bool expected)
        //{
        //    UserModel userDetails = new UserModel();
        //    bool actual = userDetails.UpdateUserStatus(userId, status);
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("1", "test1", true)]
        //[InlineData("2", "test", false)]
        //public void CheckChangeUserPassword(string userId, string password, bool expected)
        //{
        //    UserModel userDetails = new UserModel();
        //    bool actual = userDetails.ChangeUserPassword(userId, password);
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("9611703294", "test1", "1", "Vikram", "SysAdmin", "")]
        //[InlineData("9611703294", "test", "1", "Vikram", "SysAdmin", "Error")]
        //public void CheckUserLogin(string phoneNumber, string password,string expectedId,string expectedName,string expectedRole,string expectedError)
        //{
        //    UserModel userDetails = new UserModel();
        //    UserModel userInfo = userDetails.UserLogin(phoneNumber, password);
        //    if (userInfo.error == "" || userInfo.error ==null)
        //    {
        //        Assert.Equal(userInfo.userId, expectedId);
        //        Assert.Equal(userInfo.userName, expectedName);
        //        Assert.Equal(userInfo.roleName, expectedRole);
        //    }
        //    else
        //    {
        //        Assert.Equal(userInfo.error, expectedError);
        //    }
        //}
    }
}
