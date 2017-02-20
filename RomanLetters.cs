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
        public void TestReturnRomanValue()
        {
            String[] romanDigits = { "I", "IV", "V", "IX" };
            String[] romanTens = { "X", "XL", "L", "XC" };
            Assert.AreEqual("I", returnRomanValue(1,romanDigits,))
        }



        public String convertTensToRoman(int tens)
        {
            String result = "";
            if (tens < 100 && tens >= 90) 
            {
                result = "XC";
            }else
                if (tens < 90 && tens >= 80)
                {
                    result = "LXXX";
                }else
                    if (tens < 80 && tens >= 70)
                    {
                        result = "LXX";
                    }else
                        if (tens < 70 && tens >= 60)
                        {
                            result = "LX";
                        }else
                            if (tens < 60 && tens >= 50)
                            {
                                result = "L";
                            }else
                                if (tens < 50 && tens >= 40)
                                {
                                    result = "XL";
                                }else
                                    if (tens < 40 && tens >= 30)
                                    {
                                        result = "XXX";
                                    }else
                                        if (tens < 30 && tens >= 20)
                                        {
                                            result = "XX";
                                        }else
                                            if ((tens < 20) && (tens >= 10))
                                            {
                                              
                                                result = "X";
                                            }
            return result;
        
        }

        //method to return a String value representing the Roman representation of the 
        //parameter digit
        public String returnRomanValue(int digit, String[] romanValues, int[] arabicValues)
        {
            String result = "";
            while (digit > 0)
            {
                for (int i = arabicValues.Length - 1; i > 0; i--)
                {
                    if (digit == arabicValues[i])
                    {
                        digit -= arabicValues[i];
                        result += romanValues[i];
                    }   
                }
            }
        }




        public String convertDigitsToRoman(int digit)
        {
            String result = "";
            String [] romanDigits = {"I", "IV", "V", "IX"};
            String[] romanTens = { "X", "XL", "L", "XC" };
            int[] arabicDigits = { 1, 4, 5, 9 };
            int[] arabicTens = {10,40,50,90};

            return result;
        }
        
        
        public String convertNumber(int number)
        {
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

                   //add roman digits to result;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i] >= 10)
                        {
                            result = result + convertTensToRoman(digits[i]);

                        }
                        else
                        {
                            result = result + convertDigitsToRoman(digits[i]);

                        }
                    }

                  }
            return result;

        }

    }
}
