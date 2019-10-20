using System;
using System.Collections.Generic;
using Xunit;

namespace bankocr.test
{
    public class AccountNumberScannerTest
    {
        [Fact]
        public void should_return_account_number_for_123456789()
        {
            //Given
            string encodedAccountNumber = 
             "    _  _     _  _  _  _  _ \n" 
            +"  | _| _||_||_ |_   ||_||_|\n"
            +"  ||_  _|  | _||_|  ||_| _|";

            AccountNumberScanner accountNumberScanner = new AccountNumberScanner();

            //When
            string actual = accountNumberScanner.Scan(encodedAccountNumber);

            //Then
            Assert.Equal("123456789", actual);
        }

        [Fact]
        public void should_return_account_number_for_111111111()
        {
            //Given
            string encodedAccountNumber = 
             "                           \n" 
            +"  |  |  |  |  |  |  |  |  |\n"
            +"  |  |  |  |  |  |  |  |  |";

            AccountNumberScanner accountNumberScanner = new AccountNumberScanner();

            //When
            string actual = accountNumberScanner.Scan(encodedAccountNumber);

            //Then
            Assert.Equal("111111111", actual);
        }

        [Fact]
        public void should_return_account_number_for_222222222()
        {
            //Given
            string encodedAccountNumber = 
             " _  _  _  _  _  _  _  _  _ \n" 
            +" _| _| _| _| _| _| _| _| _|\n"
            +"|_ |_ |_ |_ |_ |_ |_ |_ |_ ";

            AccountNumberScanner accountNumberScanner = new AccountNumberScanner();

            //When
            string actual = accountNumberScanner.Scan(encodedAccountNumber);

            //Then
            Assert.Equal("222222222", actual);
        }

        [Fact]
        public void should_return_account_number_for_333333333()
        {
            //Given
            string encodedAccountNumber = 
             " _  _  _  _  _  _  _  _  _ \n" 
            +" _| _| _| _| _| _| _| _| _|\n"
            +" _| _| _| _| _| _| _| _| _|";

            AccountNumberScanner accountNumberScanner = new AccountNumberScanner();

            //When
            string actual = accountNumberScanner.Scan(encodedAccountNumber);

            //Then
            Assert.Equal("333333333", actual);
        }

        [Fact]
        public void should_return_account_number_for_444444444()
        {
            //Given
            string encodedAccountNumber = 
             "                           \n" 
            +"|_||_||_||_||_||_||_||_||_|\n"
            +"  |  |  |  |  |  |  |  |  |";

            AccountNumberScanner accountNumberScanner = new AccountNumberScanner();

            //When
            string actual = accountNumberScanner.Scan(encodedAccountNumber);

            //Then
            Assert.Equal("444444444", actual);
        }
    }


}
