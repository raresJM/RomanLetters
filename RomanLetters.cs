using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanLetters
{
    [TestClass]
    public class RomanLetters
    {

        [TestMethod]
        public void TestNumberLowerThanFour()
        {
            Assert.AreEqual("III", convertNumber(3));
        }
        [TestMethod]
        public void TestNumberFour()
        {
            Assert.AreEqual("IV", convertNumber(4));
        }
        [TestMethod]
        public void TestNumberEight()
        {
            Assert.AreEqual("VIII", convertNumber(8));
        }
        [TestMethod]
        public void TestNumberNine()
        {
            Assert.AreEqual("IX", convertNumber(9));
        }
        [TestMethod]
        public void TestNumberFifteen()
        {
            Assert.AreEqual("XV", convertNumber(15));
        }
        [TestMethod]
        public void TestNumberThirty()
        {
            Assert.AreEqual("XXX", convertNumber(30));
        }
        [TestMethod]
        public void TestNumberThirtyNine()
        {
            Assert.AreEqual("XXXIX", convertNumber(39));
        }
        [TestMethod]
        public void TestNumberFortyOne()
        {
            Assert.AreEqual("XLI", convertNumber(41));
        }
        [TestMethod]
        public void TestNumberFortyFive()
        {
            Assert.AreEqual("XLV", convertNumber(45));
        }
        [TestMethod]
        public void TestNumberNinetyNine()
        {
            Assert.AreEqual("XCIX", convertNumber(99));
        }
        [TestMethod]
        public void TestNumberOneHundred()
        {
            Assert.AreEqual("C", convertNumber(100));
        }
        [TestMethod]
        public void TestNumberOutOfRange()
        {
            Assert.AreEqual("ERROR!", convertNumber(101));
        }
        [TestMethod]
        public void TestReturnRomanValue_01()
        {
            String[] romanDigits = { "I", "IV", "V", "IX" };
            String[] romanTens = { "X", "XL", "L", "XC" };
            int[] arabicDigits = { 1, 4, 5, 9 };
            int[] arabicTens = { 10, 40, 50, 90 };
            Assert.AreEqual("I", returnRomanValue(1, romanDigits, arabicDigits));
        }
        [TestMethod]
        public void TestReturnRomanValue_02()
        {
            String[] romanDigits = { "I", "IV", "V", "IX" };
            String[] romanTens = { "X", "XL", "L", "XC" };
            int[] arabicDigits = { 1, 4, 5, 9 };
            int[] arabicTens = { 10, 40, 50, 90 };
            Assert.AreEqual("X", returnRomanValue(10, romanTens, arabicTens));
        }

        //method to return a String value representing the Roman 
        //representation of the 
        //parameter digit
        public String returnRomanValue(int digit, String[] roman, int[] arabic)
        {
            String result = "";
            while (digit > 0)
            {

                for (int i = arabic.Length - 1; i >= 0; i--)
                {
                    if (digit >= arabic[i])
                    {
                        result = result + roman[i];
                        digit = digit - arabic[i]; 
                    }   
                }
            }
            return result;
        }

        public String convertNumber(int number)
        {
            String[] romanDigits = { "I", "IV", "V", "IX" };
            String[] romanTens = { "X", "XL", "L", "XC" };
            int[] arabicDigits = { 1, 4, 5, 9 };
            int[] arabicTens = { 10, 40, 50, 90 };

            String result = "";

            if ((number < 1) || (number > 100)) 
            {
                result = "ERROR!";
            } 
            else if (number == 100)
            {
                result = "C";
            }
            else {
                      //create an array of digits.
                String numberAsString = Convert.ToString(number);

                char[] charDigits = numberAsString.ToCharArray();

                int[] digits = new int[numberAsString.Length];

               //put digits in an array of digits
                for (int i = 0; i < digits.Length; i++)
                {
                    digits[i] = (int)char.GetNumericValue(charDigits[i]);
                    
                }
                         
                //replace digits with digit*powerOf10
                    for (int i = 0; i < digits.Length; i++)
                    {
                        digits[i] = digits[i] * (int)Math.Pow(10, (digits.Length-1 - i));
                    }

                   //add roman values to result;
                   for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i] >= 10)
                        {
                            result = result + returnRomanValue(digits[i],romanTens,arabicTens);

                        }
                        else
                        {
                        result = result + returnRomanValue(digits[i],romanDigits,arabicDigits);
                        }
                    }

                  }
            return result;

        }

    }
}
