using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace TDE
{
    public class PasswordVerifier
    {
        [Theory]
        [InlineData("2short")]
        [InlineData("VeryLongPassowrd")]
        [InlineData("short")]
        [InlineData("ThisIsThePassWordThatNeverEnds")]

        
        public void TestLength(string password)
        { 

            bool actual = Password.VerifyLength(password);
            bool expected = false;

            Assert.Equal(expected, actual);
            //Assert.True(actual);
        }

        [Theory]
        [InlineData("2short")]
        [InlineData("VeryLongPassowrd")]
        [InlineData(" ")]
        [InlineData("ThisIsThePassWordThatNeverEnds")]


        public void TestNotNull(string password)
        {

            bool actual = Password.VerifyNotNull(password);
            bool expected = true;

            Assert.Equal(expected, actual);  
        }

        [Theory]
        [InlineData("2short")]
        [InlineData("VeryLongPassowrd")]
        [InlineData(" ")]
        [InlineData("ThisIsThePassWordThatNeverEnds")]


        public void TestUpper(string password)
        {

            bool actual = Password.VerifyUpper(password);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("2short")]
        [InlineData("VeryLongPassowrd")]
        [InlineData("THISBETTERFAIL")]
        [InlineData("ThisIsThePassWordThatNeverEnds")]


        public void TestLower(string password)
        {

            bool actual = Password.VerifyLower(password);
            bool expected = true;

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData("2short")]
        [InlineData("VeryLongPassowrd")]
        [InlineData(" ")]
        [InlineData("ThisIsThePassWordThatNeverEnds")]


        public void TestNum(string password)
        {

            bool actual = Password.VerifyNum(password);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
    }

}
