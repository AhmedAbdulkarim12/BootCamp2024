using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BootCamp2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Q26();
            Q27();
            Q28();
            Q29();
            Q30();
            Q31();
            Q32();
            Q33();
            Q34();
            Q35();
            Q36();
            Q37();
            Q38();
            Q39();
            Q40();
            Q41();
            Q42();
            Q43();
            Q44();
            Q45();
            Q46();
            Q47();
            Q48();
            Q49();
            Q50();
            Q51();
            Q52();
            Q53();
            Q54();
            Q55();
            Q56();
            Q57();
            Q58();
            Q59();
            Q60();
            Q61();
            Q62();
            Q63();
            Q64();
            Q65();
            Console.ReadKey();
        }


        //Q1 (Q26) 
        static void Q26()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to accept two integers and check whether they are equal or not.");
            Console.WriteLine("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2st number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CheckTwoNumberIsEqual(num1  , num2);
            
        }

        //Q2 (Q27) 
        static void Q27()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether a given number is even or odd.");
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            CheckIsOddOrEven(num);
        }

        //Q3 (Q28) 
        static void Q28()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether a given number is positive or negative.");
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            CheckIsPositiveOrNegative(num);
        }

        //Q4 (Q29) 
        static void Q29()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to find out whether a given year is a leap year or not.");
            Console.WriteLine("Input year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            CheckYearIsLeap(year);
        }

        //Q5 (Q30) 
        static void Q30()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.");
            Console.WriteLine("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckCandidateAge(age);
        }

        //Q6 (Q31) 
        static void Q31()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.");
            Console.WriteLine("Input m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Nvalue(m);
        }


        //Q7 (Q32) 
        static void Q32()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.");
            Console.WriteLine("height : ");
            int height = Convert.ToInt32(Console.ReadLine());

            CheckHeight(height);
        }

        //Q8 (Q33) 
        static void Q33()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to find the largest of three numbers.");
            Console.WriteLine("Input the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2st number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3st number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            FindLargestOfThreeNumbers(num1,num2,num3);
        }

        //Q9 (Q34) 
        static void Q34()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.");
            Console.WriteLine("Input the value for X coordinate : ");
            int Xcoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate : ");
            int Ycoordinate = Convert.ToInt32(Console.ReadLine());

            DetermineCoordinatePoint(Xcoordinate, Ycoordinate);
        }

        //Q10 (Q35) 
        static void Q35()//*
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:\r\nMarks in Maths >=65\r\nMarks in Phy >=55\r\nMarks in Chem>=50\r\nTotal in all three subject >=180\r\nor\r\nTotal in Math and Subjects >=140");
           
        }

        //Q11 (Q36) 
        static void Q36()//*
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to calculate the root of a quadratic equation.");

        }


        //Q12 (Q37) 
        static void Q37()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.");
            Console.WriteLine("Input the Roll Number of the student: ");
            int RollNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Name of the Student: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics: ");
            int marksPhysics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks of Chemistry: ");
            int marksChemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks of Computer Application: ");
            int marksComputer = Convert.ToInt32(Console.ReadLine());

            CalculateTotalPercentageAndDivision(RollNum, Name, marksPhysics, marksChemistry, marksComputer);
        }

        //Q13 (Q38) 
        static void Q38()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:\r\nTemp < 0 then Freezing weather\r\nTemp 0-10 then Very Cold weather\r\nTemp 10-20 then Cold weather\r\nTemp 20-30 then Normal in Temp\r\nTemp 30-40 then Its Hot\r\nTemp >=40 then Its Very Hot");
            Console.WriteLine("Input the temperature: ");
            int Temperature = Convert.ToInt32(Console.ReadLine());


            TemperatureState(Temperature);
        }

        //Q14 (Q39) 
        static void Q39()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.");
            Console.WriteLine("Input the 1st side length: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2st side length: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3st side length: ");
            int length3 = Convert.ToInt32(Console.ReadLine());

            CheckTriangleType(length1, length2, length3);
        }

        //Q15 (Q40) 
        static void Q40()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether a triangle can be formed by the given angles value.");
            Console.WriteLine("Input the 1st angles: ");
            int angles1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2st angles: ");
            int angles2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3st angles: ");
            int angles3 = Convert.ToInt32(Console.ReadLine());

            CheckTriangLecanBeFormed(angles1, angles2, angles3);
        }

        //Q16 (Q41) 
        static void Q41()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.");
            Console.WriteLine("Input the letter : ");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());

            CheckAlphabetLetter(letter);
        }

        //Q17 (Q42) 
        static void Q42()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to calculate profit and loss on a transaction.");
            Console.WriteLine("Input first value: ");
            int fValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second value: ");
            int sValue = Convert.ToInt32(Console.ReadLine());

            ClculateProfitAndLoss(fValue, sValue);

        }

        //Q18 (Q42) 
        static void Q43()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard, " +
                                  "the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.\r\n" +
                                  "The charge are as follow :\r\nUnit\r\nCharge/unit\r\nupto 199\r\n@1.20\r\n200 and above but less than 400\r\n@1.50\r\n" +
                                  "400 and above but less than 600\r\n@1.80\r\n600 and above\r\n@2.00\r\n\r\nIf bill exceeds Rs. 400 then a surcharge of 15% will " +
                                  "be charged and the minimum bill should be of Rs. 100/-");
            Console.WriteLine("Input Customer IDNO : ");
            int IDNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Customer Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Input unit Consumed : ");
            int unit = Convert.ToInt32(Console.ReadLine());

            CalculateElectricityBill(IDNO, Name, unit);

        }

        //Q19 (Q44) 
        static void Q44()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to accept a grade and declare the equivalent description :\r\nGrade\r\nDescription\r\nE\r\nExcellent\r\nV\r\nVery Good\r\nG\r\nGood\r\nA\r\nAverage\r\nF\r\nFail\r\n");
            Console.WriteLine("Input the grade :");
            char grade = Convert.ToChar(Console.ReadLine().ToLower());

            DeclareGrade(grade);

        }

        //Q20 (Q45) 
        static void Q45()
        {
            Console.WriteLine("\r\n Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.");
            Console.WriteLine("Input day number :");
            int DayNum = Convert.ToInt32(Console.ReadLine());

            GetDayName(DayNum);

        }

        //Q21 (Q46) 
        static void Q46()
        {
            Console.WriteLine("\r\n Write a program in C# Sharp to read any digit, display in the word.\r\n");
            Console.WriteLine("Input digit :");
            int digit = Convert.ToInt16(Console.ReadLine());

            GetDigitName(digit);

        }

        //Q22 (Q47) 
        static void Q47()
        {
            Console.WriteLine("\r\nWrite C# Sharp program to read any Month Number in integer and display Month name.\r\n");
            Console.WriteLine("Input Month Number :");
            int MonthNum = Convert.ToInt16(Console.ReadLine());

            GetMonthName(MonthNum);

        }

        //Q23 (Q48) 
        static void Q48()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to read any Month Number in integer and display the number of days for this month.\r\n");
            Console.WriteLine("Input Month Number :");
            int MonthNum = Convert.ToInt16(Console.ReadLine());

            GetNumberDayInThisMonth(MonthNum);

        }

        //Q24 (Q49) 
        static void Q49()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.\r\n\r\n" +
                              "1.Calculate the area of a circle\r\n" +
                              "2.Calculate the area of a square\r\n" +
                              "3.Calculate the area of a rectangle\r\n");
            Console.WriteLine("Input your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());

            CalculateAreaOfShapes(choice);

        }

        //Q1 (Q50) 
        static void Q50()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to input a string and print it.\r\n");
            Console.WriteLine("Input the string : ");
            String Text = Console.ReadLine();
            Console.WriteLine("The string you entered is : " + Text);
        }

        //Q2 (Q51) 
        static void Q51()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to find the length of a string without using a library function.\r\n");
            Console.WriteLine("Input the string :");
            string Text = Console.ReadLine();

            int TextLength = 0;
            foreach (char c in Text)
                TextLength++;
            
            Console.WriteLine("Length of the string is :" + TextLength);
        }

        //Q3 (Q52) 
        static void Q52()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to separate individual characters from a string.\r\n");
            Console.WriteLine("Input the string :");
            string Text = Console.ReadLine();
            foreach (char c in Text)
                Console.WriteLine(c);
        }

        //Q4 (Q53) 
        static void Q53()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to print individual characters of the string in reverse order.\r\n");
            Console.WriteLine("Input the string :");
            string Text = Console.ReadLine();
            for (int i = Text.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Text[i]);
            }
        }

        //Q5 (Q54) 
        static void Q54()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to count the total number of words in a string.\r\n");
            Console.WriteLine("Input the string :");
            string Text = Console.ReadLine();
            Text = Regex.Replace(Text, @"\s+", " ");
            var WordList = Text.Split(' ');
            Console.WriteLine("Total number of words in the string is : " + WordList.Length);
        }

        //Q6 (Q55) 
        static void Q55()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to compare two strings without using a string library functions.\r\n");
            Console.WriteLine("Input the 1st string : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Input the 2st string : ");
            string str2 = Console.ReadLine();
            Console.WriteLine(str1 == str2 ? "The length of both strings are equal and also, both strings are equal." : "The length of both strings are not equal or both strings are not equal.");
        }

        //Q7 (Q56) 
        static void Q56()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to count the number of alphabets, digits and special characters in a string.\r\n");
            Console.WriteLine("Input the string :");
            string Text = Console.ReadLine();

            int AlphabetsCount = 0;
            int DigitsCount = 0;
            int SpecialCharsCount = 0;

            foreach (char c in Text)
            {
                if (char.IsLetter(c))
                {
                    AlphabetsCount += 1;
                }
                else if (char.IsDigit(c))
                {
                    DigitsCount += 1;
                }
                else
                {
                    SpecialCharsCount += 1;
                }
            }

            Console.WriteLine("Number of Alphabets in the string is: " + AlphabetsCount);
            Console.WriteLine("Number of Digits in the string is: " + DigitsCount);
            Console.WriteLine("Number of Special characters in the string is: " + SpecialCharsCount);

        }

        //Q8 (Q57) 
        static void Q57()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to copy one string to another string.\r\n\r\n");
            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            string str2 = String.Copy(str);
            Console.WriteLine("The First string is : " + str);
            Console.WriteLine("The Second string is : " + str2);
            Console.WriteLine("Number of characters copied : " + str.Length);
        }

        //Q9 (Q58) 
        static void Q58()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to count the number of vowels or consonants in a string.\r\n\r\n");
            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char c in str)
            {
                if ("aeiou".Where(x => x == c).Count() == 1)
                    vowelCount += 1;
                else if (char.IsLetter(c))
                    consonantCount += 1;
            }
            
            Console.WriteLine("The total number of vowel in the string is : " + vowelCount);
            Console.WriteLine("The total number of consonant in the string is : " + consonantCount);
        }

        //Q10 (Q59) 
        static void Q59()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to find the maximum number of characters in a string.\r\n");
            
        }//*

        //Q11 (Q60)  
        static void Q60()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to sort a string array in ascending order.\r\n");
            Console.WriteLine("Input the string :");
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            
            Console.WriteLine("After sorting the string appears like : ");
            foreach (char c in charArray)
            {
                Console.Write(c + " ");
            }
        }

        //Q12 (Q61)  
        static void Q61()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read a string through the keyboard and sort it using bubble sort.\r\n");
            Console.WriteLine("Input number of strings :");
            int numStr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input "+ numStr +" strings below :");

            string[] strArray = new string[numStr];

            for (int i = 0; i < numStr; i++)
            {
                strArray[i] = Console.ReadLine();
            }


            /*
            string[] strArray = new string[numStr];

            for (int i = 0; i < numStr; i++)
            {

                strArray[i] = Console.ReadLine();

                if (i > 0)
                {
                    int ShorterLen;
                    Boolean FoundLarger = false;
                    Boolean NewStringShorter = false;


                    if (strArray[i].Length > strArray[i - 1].Length)
                    {ShorterLen = strArray[i - 1].Length;}
                    else
                    { 
                        ShorterLen = strArray[i].Length;
                        NewStringShorter = true;
                    }

                    for (int j = 0; j < ShorterLen; j++)
                    {
                        if (strArray[i - 1][j] > strArray[i][j])
                        {
                            var temp = strArray[i - 1];
                            strArray[i - 1] = strArray[i];
                            strArray[i] = temp;
                            FoundLarger = true;
                            break;
                        }
                        else if (strArray[i - 1][j] < strArray[i][j])
                        {
                            FoundLarger = true;
                            break;
                        }
                    }

                    if (FoundLarger == false && NewStringShorter == true)
                    {
                        var temp = strArray[i - 1];
                        strArray[i - 1] = strArray[i];
                        strArray[i] = temp;
                    }
                }
            }


            Console.WriteLine("After sorting the array appears like :");

            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }
            */
            /*
            string[] strArray = new string[numStr];

            for (int i = 0; i < numStr; i++)
            {
                strArray[i] = Console.ReadLine();
            }

            Console.WriteLine("After sorting the array appears like :");


            for (int i = 0; i < numStr - 1; i++)
            {
                for (int j = 0; j < numStr - 1; j++)
                {
                    for (int k = 0; k < strArray[j].Length - 1; k++)
                    {
                        if (strArray[j][k] < strArray[i][k])
                        {
                            
                            var temp = strArray[j]; 
                            if (j < i)
                            {
                                for (int m = j; m < i; m++)
                                {
                                    strArray[m] = strArray[m + 1]; 
                                }
                            }
                            else
                            {
                          
                                for (int m = j; m > i; m--)
                                {
                                    strArray[m] = strArray[m - 1];
                                }
                            }
                            strArray[i] = temp; 


                            //j = 0;
                            break;
                        }
                    }
                }
            }
            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }
            */



            Console.WriteLine("After sorting the array appears like :");

            for (int i = 0; i < numStr - 1; i++)
            {
                for (int j = 0; j < numStr - 1; j++) 
                {
                    int ShorterLen = strArray[j].Length < strArray[j + 1].Length ? strArray[j].Length  : strArray[j+1].Length;

                    for (int k = 0; k < ShorterLen; k++)
                    {
                        if (strArray[j][k] > strArray[j + 1][k])
                        {
                            string temp = strArray[j];
                            strArray[j] = strArray[j + 1];
                            strArray[j + 1] = temp;
                            break;
                        }
                        else if (strArray[j][k] < strArray[j + 1][k])
                            break;
                    }
                }
            }

            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }


        }//**


            //Q13 (Q62)  
            static void Q62()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to extract a substring from a given string without using the library function.\r\n");
            Console.WriteLine("Input the string : ");
            string Str = Console.ReadLine();
            Console.WriteLine("Input the position to start extraction :");
            int startPos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the length of substring :");
            int len = Convert.ToInt32(Console.ReadLine());
            int EndPos = startPos + len;
            int count = 0;
            string NewStr = "";

            foreach (char c in Str) 
            {
                count += 1;
                if (count >= startPos && count <= EndPos)
                {
                    NewStr += c;
                }else if (count > EndPos) { break; }
            }
            Console.WriteLine("The substring retrieve from the string is : " + NewStr);

        }

        //Q14 (Q63)  
        static void Q63()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to check whether a given substring is present in the given string.\r\n");
            Console.WriteLine("Input the string : ");
            string Str = Console.ReadLine();
            Console.WriteLine("Input the substring to search : ");
            string SubStr = Console.ReadLine();
            
            Console.WriteLine(Str.Contains(SubStr) ? "The substring exists in the string": "The substring not exists in the string");

        }

        //Q15 (Q64)  
        static void Q64()
        {
            Console.WriteLine("\r\nWrite a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.\r\n");
            Console.WriteLine("Input the string : ");
            string Str = Console.ReadLine();

            char[] charArray = Str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = char.IsLower(Str[i]) ? char.ToUpper(Str[i]) : char.ToLower(Str[i]);
            }
            
            Console.WriteLine("After conversion, the string is : " + charArray.ToString());
        }

        //Q16 (Q65)  
        static void Q65()
        {
            Console.WriteLine("\r\nWrite a program in C# Sharp to check the username and password.\r\n");
            Console.WriteLine("Input a username: ");
            string SignUpUserName = Console.ReadLine();
            Console.WriteLine("Input a password: ");
            string SignUpPassword = Console.ReadLine();

            Console.WriteLine("Input a username: ");
            string LogInUserName = Console.ReadLine();
            Console.WriteLine("Input a password: ");
            string LogInPassword = Console.ReadLine();

            if (SignUpUserName == LogInUserName && SignUpPassword == LogInPassword)
            Console.WriteLine("Password entered successfully!");
            else
                Console.WriteLine("password or username incorrect");
        }

        static void CheckTwoNumberIsEqual(int _num1, int _num2)
        {
            Console.WriteLine(_num1 == _num2 ? (_num1 + " and " + _num2 + " are equal") : (_num1 + " and " + _num2 + " are not equal"));
        }
        static void CheckIsOddOrEven(int _num)
        {
            Console.WriteLine(_num % 2 == 0 ? (_num + " is an even integer") : (_num + " is an odd integer"));
        }
        static void CheckIsPositiveOrNegative(int _num)
        {
            Console.WriteLine(_num >= 0 ? (_num + " is a positive number") : (_num + " is a negative number"));
        }
        static void CheckYearIsLeap(int _year)
        {
            Console.WriteLine(_year % 4 == 0 ? (_year + " is a leap year.") : (_year + " is not leap year."));
        }
        static void CheckCandidateAge(int _age)
        {
            Console.WriteLine(_age >= 18 ? ("Congratulation! You are eligible for casting your vote.") : ("sorry! You are not eligible for casting your vote."));
        }
        static void Nvalue(int _m)
        {
            if (_m > 0) { Console.WriteLine("The value of n = -1");}
            else if (_m == 0) { Console.WriteLine("The value of n = 0"); }
            else { Console.WriteLine("The value of n = -1"); }
        }
        static void CheckHeight(int _height)
        {
            if (_height <= 150) { Console.WriteLine("The person is Dwarf."); }
            else if (_height > 150 && _height <= 180) { Console.WriteLine("The person is Normal."); }
            else { Console.WriteLine("The person is Tall."); }
        }

        static void FindLargestOfThreeNumbers(int _num1, int _num2, int _num3)
        {
            if (_num1 > _num2 && _num1 > _num3) { Console.WriteLine("The 1nd Number is the greatest among three"); }
            else if (_num2 > _num1 && _num2 > _num3) { Console.WriteLine("The 2nd Number is the greatest among three"); }
            else if (_num3 > _num1 && _num3 > _num2) { Console.WriteLine("The 3nd Number is the greatest among three"); }
            else { Console.WriteLine("There are equal numbers"); }
        }

        static void DetermineCoordinatePoint(int _Xcoordinate, int _Ycoordinate)
        {
            if (_Xcoordinate > 0 && _Ycoordinate > 0) { Console.WriteLine("The coordinate point (" + _Xcoordinate + "," + _Ycoordinate + ") lies in the First quadrant."); }
            else if (_Xcoordinate < 0 && _Ycoordinate > 0) { Console.WriteLine("The coordinate point (" + _Xcoordinate + "," + _Ycoordinate + ") lies in the Second quadrant."); }
            else if (_Xcoordinate < 0 && _Ycoordinate < 0) { Console.WriteLine("The coordinate point (" + _Xcoordinate + "," + _Ycoordinate + ") lies in the Third quadrant."); }
            else if (_Xcoordinate > 0 && _Ycoordinate < 0) { Console.WriteLine("The coordinate point (" + _Xcoordinate + "," + _Ycoordinate + ") lies in the Fourth quadrant."); }
            else Console.WriteLine("The coordinate point (" + _Xcoordinate + "," + _Ycoordinate + ") lies Is Neutral point");
        }

        static void CalculateTotalPercentageAndDivision(int _RollNum, string _Name, int _marksPhysics, int _marksChemistry, int _marksComputer)
        {
            Console.WriteLine("Roll No : " + _RollNum);
            Console.WriteLine("Name of Student : " + _Name);
            Console.WriteLine("Marks in Physics : " + _marksPhysics);
            Console.WriteLine("Marks in Chemistry : " + _marksChemistry);
            Console.WriteLine("Marks in Computer Application : " + _marksComputer);
            Console.WriteLine("Total Marks = " + (_marksPhysics + _marksChemistry + _marksComputer));
            Console.WriteLine("Percentage = " + ((_marksPhysics + _marksChemistry + _marksComputer) / 3));
            Console.WriteLine("Division = "); //*
        }

        static void TemperatureState(int _Temperature)
        {
            if (_Temperature < 0) { Console.WriteLine("Freezing weather"); }
            else if (_Temperature >= 0 && _Temperature < 10) { Console.WriteLine("Very Cold weather"); }
            else if (_Temperature >= 10 && _Temperature < 20) { Console.WriteLine("Cold weather"); }
            else if (_Temperature >= 20 && _Temperature < 30) { Console.WriteLine("Normal in Temp"); }
            else if (_Temperature >= 30 && _Temperature < 40) { Console.WriteLine("Its Hot"); }
            else { Console.WriteLine("Its Very Hot"); }
        }
        static void CheckTriangleType(int _length1, int _length2, int _length3)
        {
            if (_length1 == _length2 && _length1 == _length3) { Console.WriteLine("This is an equilateral triangle."); }
            else if (_length1 == _length2 || _length1 == _length3 || _length2 == _length3) { Console.WriteLine("This is an isosceles triangle."); }
            else { Console.WriteLine("This is an scalene triangle."); }
        }
        static void CheckTriangLecanBeFormed(int _angles1, int _angles2, int _angles3)
        {
            Console.WriteLine(_angles1 + _angles2 + _angles3 == 180 ? ("The triangle is valid.") : ("The triangle is not valid."));
        }
        static void CheckAlphabetLetter(char _letter)
        {
            Console.WriteLine("aeiou".Where(c => c == _letter).Count() == 1 ? ("The alphabet is a vowel.") : ("The alphabet is a consonant."));
        }

        static void ClculateProfitAndLoss(int _fValue, int _sValue)
        {
            var amount = _sValue - _fValue;
            Console.WriteLine(amount > 0 ? ("You can book your profit amount :" + amount) : ("You can book your loss amount :" + amount));
        }

        static void CalculateElectricityBill(int _IDNO, string _Name, int _unit)
        {
            double UnitCharge;
            double AmountCharges;
            double SurchageAmount;

            if (_unit < 200) { UnitCharge = 1.20; }
            else if (_unit >= 200 && _unit < 400) { UnitCharge = 1.50; }
            else if (_unit >= 400 && _unit < 600) { UnitCharge = 1.80; }
            else { UnitCharge = 2.00; }

            AmountCharges = _unit * UnitCharge;
            AmountCharges = AmountCharges < 100 ? 100 : AmountCharges;

            SurchageAmount = AmountCharges > 400 ? AmountCharges * 0.15 : 0;

            Console.WriteLine("Customer IDNO :" + _IDNO);
            Console.WriteLine("Customer Name :" + _Name);
            Console.WriteLine("unit Consumed :" + _unit);

            Console.WriteLine("Amount Charges @Rs." + UnitCharge + " per unit : " + AmountCharges);
            Console.WriteLine("Surchage Amount : " + SurchageAmount);
            Console.WriteLine("Net Amount Paid By the Customer : " + (AmountCharges + SurchageAmount));
        }
        static void DeclareGrade(char _grade)
        {
            switch (_grade)
            {
                case 'E':
                    Console.WriteLine("You have chosen : Excellent");
                    break;
                case 'V':
                    Console.WriteLine("You have chosen : Very Good");
                    break;
                case 'G':
                    Console.WriteLine("You have chosen : Good");
                    break;
                case 'A':
                    Console.WriteLine("You have chosen : Average");
                    break;
                case 'F':
                    Console.WriteLine("You have chosen : Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade char");
                    break;
            }
        }

        static void GetDayName(int _DayNum)
        {
            switch (_DayNum)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }

        static void GetDigitName(int _digit)
        {
            switch (_digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;

                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Invalid digit");
                    break;
            }
        }

        static void GetMonthName(int _MonthNum)
        {
            switch (_MonthNum)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
        }


        static void GetNumberDayInThisMonth(int _MonthNum)
        {
            switch (_MonthNum)
            {
                case 1:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have either 28 or 29 days");
                    break;
                case 3:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 4:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 5:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 6:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 7:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 8:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 9:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 10:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
        }


        static void CalculateAreaOfShapes(int _choice)
        {
            switch (_choice)
            {
                case 1:
                    Console.Write("Input radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area is: ", (Math.PI * radius * radius));
                    break;
                case 2:
                    Console.Write("Input side length of the square: ");
                    double sideLength = Convert.ToDouble(Console.ReadLine());;
                    Console.WriteLine("The area is: ", (sideLength * sideLength));
                    break;
                case 3:
                    Console.Write("Input length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area is: ", (length * width));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
