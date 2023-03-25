using System;
using System.Linq;
using System.Text;

namespace IterviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ///swaping of two numbers using 3 variables////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            
            Console.WriteLine("Enter first number: ");
            int num1=Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" both numbers before swaping:{num1} and{num2} ");

            int temp;
            temp = num1;
            num1 = num2;
            num2= temp;

            Console.WriteLine($" both numbers after swaping:{num1} and{num2} ");
            

            /////////////////////////////// prime or not////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             Console.WriteLine("Enter a Number");
             int num3 =Convert.ToInt32(Console.ReadLine());
             int a = 0;
             for(int i=1;i<=num3;i++)
             {
                 if(num3%i==0)
                 {
                     a += 1;
                 }
             }
             if(a==2)
             {
                 Console.WriteLine($"the number {num3} is Prime ");
             }
             else
             {
                 Console.WriteLine($"the number {num3} is Not Prime ");

             }
            */
            //////////////////////////////////////////////////////////////////////////////////
            ////////////////////////prime number count between 1 and 100//////////////////////
            /*
            for(int num=1;num<=100;num++)
             {
                 int count = 0;
                 for(int i=1;i<=num;i++)
                 {
                     if(num%i==0)
                     {
                         count += 1;
                     }

                 }
                 if(count==2)
                 {
                     Console.WriteLine(num);
                 }
             }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////to print reverse statement and numbers/////////////////////////////
            /*
            Console.WriteLine("Please Enter the Sentence");
            string input =Console.ReadLine();
            string[] words = input.Split(new char[] {' '}) ;
            for(int i=words.Length-1;i>=0;i--)
            {
                Console.Write(words[i]+" ");
            }
            */
            /////////////////////////////////////////////////////////////////////////////////
            ////
            /*
            int[] arr = new int[] { 12,34,45,67,78,89};
            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.Write(arr[i] +" ");
            }
            Console.ReadLine();
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////second higest Number from array////////////////////////////////////////////
            /*
            Console.WriteLine("Print second higest number in array");
            int Max1, Max2;
            int[] arr = new int[] {12,45,67,89,65,23,45,13,56,50 };
            Console.WriteLine(" The Given Array list:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Max1 = Max2 = arr[0];
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]>Max1)
                {
                    Max2 = Max1;
                    Max1 = arr[i];
                }
                else if(arr[i]>Max2)
                {
                    Max2 = arr[i];
                }
            }
            Console.WriteLine($"\n  Higest number from Array:{Max1} ");
            Console.WriteLine($"Second Higest Number From Array:{Max2} ");*/

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////program to find armstrong or not upto 3 digit//////////////////////////////
            /*
            Console.WriteLine("Please Enter Armstrong Number:");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem, cube;
            int result=0;
            int temp = num;
            while(num!=0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                result = result + cube;
                num = num / 10;

            }
            Console.WriteLine(result);
            num = temp;
            if(num==result)
            {
                Console.WriteLine("Given Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Given Number is not  Armstrong");

            }
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////program to find armstrong of any digit/////////////////////////////////////////////////////
            /*
            Console.WriteLine("Please Enter Any Number to Armstrong or not:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = num;
            int rem, cube;
            int result = 0;
            while (num!=0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine($"This is {count} digit Number");
            num = temp;
            while (num != 0)
            {
                rem = num % 10;
                cube = (int)Math.Pow(rem,count);
                result = result + cube;
                num = num / 10;

            }
            Console.WriteLine($" Result is {result}");
            num = temp;
            if (num == result)
            {
                Console.WriteLine("Given Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Given Number is not  Armstrong");

            }

            Console.ReadLine();
            */


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////Reverse Number and palindrome Number//////////////////////////////////////////////////////
            //1234
            /*
            Console.WriteLine("........To print number as reverse........");
            Console.WriteLine("Please enter the number want to reverse:");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem;
            int result = 0;
            while(num!=0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine(result);

            Console.ReadLine();
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////palindrome Number///////////////////////////////////////////////////////////////////////
            /*
            Console.WriteLine("Please enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int result = 0;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }

            num = temp;
            Console.WriteLine(result);
            if(num==result)
            {
                Console.WriteLine("The Entered Number is Palindrome");
            }
            else
            {
                Console.WriteLine("The Entered Number is not Palindrome");

            }

            Console.ReadLine();
            
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////Reverse string and palindrome/////////////////////////////////////////////////////////
            /*
            Console.WriteLine("....To print reverse string..... ");
            string str;
            string Reverse = " ";
            Console.WriteLine("Enter string want to reverse");
            str=Console.ReadLine();
            str.ToLower();
            for(int i=str.Length-1;i>=0;i--)
            {
                Reverse = Reverse + str[i];
            }
            Console.WriteLine(Reverse);
            if(str==Reverse)
            {
                Console.WriteLine("ENTERED STRING IS PALINDROME");
            }
            else
            {
                Console.WriteLine("entered string is not palindrome");
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////factorial of a number//////////////////////////////////////////////////
            /*
            int fact = 1;
            Console.WriteLine("-----To find factorial of a number-------------");
            Console.WriteLine("Please Enter the Number:");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////FIBONACCI NUMBER///////////////////////////////////////////////////////////////
            /*
            Console.WriteLine("Please Enter The Length of fibonacci series");
            int L=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            for(int i=0;i<=L;i++)
            {
                c = a + b;
                Console.Write(c+ " ");
                a = b;
                b = c;
            }

            Console.ReadLine();
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////LARGEST ELEMENT IN ARRAY//////////////////////////////////////////////////////////////
            /*
            int Max=0;
            Console.WriteLine("-----find a largest element in an array");
            int[] arr = new int[] { 23, 56, 78, 90, 67, 45, 34, 3, 4, 6, 8, 99 };
            Console.WriteLine("array elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]>Max)
                {
                     Max=arr[i];
                }
            }
            Console.WriteLine($"\n largest element in given array: {Max}");
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////TO COUNT NO OF LETTERS IN STRING OR NO OF EMPTY STRING/////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*

            Console.WriteLine("----to count number of letters in string --------------------");
            Console.WriteLine("Enter the String which you wanted to count");
              string str= Console.ReadLine();
            int count=0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i] !=' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of letters in string is: {count}");

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
   /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("----to count number empty spaces in string --------------------");
            Console.WriteLine("Enter the String which you wanted to count");
            string str1 = Console.ReadLine();
            int count1 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')
                {
                    count1++;
                }
            }
            Console.WriteLine($"Number of empty spaces in string is: {count1}");

            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////insert number or element at particular position in an array /////////////////////////////////////////
            //10 12 17 15 8 17 23
            //now insert new element at position of 17

            /*
            //1.declare an array
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            //2.logic to insert element in array
            print(arr);
            InsertElement(arr, 4, 100);
            //3.print value
            print(arr);

        }


        static void InsertElement(int[] a, int position, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == position)
                {
                    a[position] = value;
                }
            }
        }

        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////deleting element or number from array at particular position/////////////////////////

            /*
                        int[] arr = new int[] { 10, 20, 30, 40, 50 };
                        Console.WriteLine("Elements Before deleting");
                        print(arr);

                        DeleteElement(arr, 20);

                    }

                    static void print(int[] array)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write(array[i] + " ");
                        }

                        Console.WriteLine();
                    }
                    static void DeleteElement(int[] a, int value)
                    {
                        int position = -1;
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (value == a[i])
                            {
                                position = i;
                                break;
                            }
                        }


                        if (position == -1)
                        {
                            Console.WriteLine("Element didnt find in the array list");
                        }
                        else
                        {
                            for (int i = position; i < a.Length - 1; i++)
                            {
                                a[i] = a[i + 1];
                            }
                            Console.WriteLine("Elements after deleting");
                            for (int i = 0; i < a.Length - 1; i++)
                            {
                                Console.Write(a[i] + " ");
                            }
                        }



                    }
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////count total numbers of words in string////////////////////////////////////////////////
            /*
            string str;
            int count = 1, len = 0;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            while ( len<=str.Length-1)
            {
                if(str[len]==' '||str[len]=='\n'||str[len]=='\t')
                    {
                    count++;
                }
                len++;
            }
            Console.WriteLine($"Total Number Of words:{count}");
            Console.ReadLine();
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////sub string///////////////////////////////////////////////////////////
            //   abc
            //a ab abc b bc c
            /*
              Console.WriteLine("Enter the string");
              string str = Console.ReadLine();
              for(int i=0;i<str.Length;i++)
              {
                  StringBuilder newstring = new StringBuilder();

                  for(int j=i;j<str.Length;j++)
                  {
                      newstring.Append(str[j]);
                      Console.Write(newstring+" ");
                  }
              }
              Console.ReadLine();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////Check string if contains vowels and count number of vowels 
            ////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             Console.WriteLine("Enter the string");
             string str = Console.ReadLine();
             bool result=IsVowel(str);
             if(result)
             {
                 Console.WriteLine("Entered string contains vowels");
             }
             else
             {
                 Console.WriteLine("Entered string does not contains vowels");

             }

             Count(str);

             Console.ReadLine();
         }

         static bool IsVowel(string str)//method to check vowels
         {
             str.ToLower();
             char[] character = str.ToCharArray();
             for(int i=0;i<character.Length;i++)
             {
              if(character[i]=='a'|| character[i] == 'e' || character[i] == 'i' || character[i] == 'o' || character[i] == 'u' )
                 {
                     return true;
                 }
             }
             return false;
         }

         static void Count(string str)//method to count vowels
         {
             str.ToLower();
             char[] character = str.ToCharArray();
             int count= 0;
             for (int i = 0; i < character.Length; i++)
             {
                 if (character[i] == 'a' || character[i] == 'e' || character[i] == 'i' || character[i] == 'o' || character[i] == 'u')
                 {
                     count++;
                 }
             }
             Console.WriteLine($"The Number Of vowels In the String :{count}");
            // return false;
         }
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////REMOVE DUPLICATE CHARACTER FROM STRING and Count Them///////////////////////////////
            /*
             Console.WriteLine("Enter the String:");
             string str=Console.ReadLine();
             string result = string.Empty;

             for(int i=0;i<str.Length;i++)
             {
                 if(!result.Contains(str[i]))
                 {
                     result += str[i];

                 }
             }

             Console.WriteLine(result);
             int count = str.Length - result.Length;
             Console.WriteLine($"Number of duplicate character are:{count}");
             Console.ReadLine();
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////Find the index of special character using IndexOf()//////////////////////////////////////
            /*
            string str = "Csharp#";
            Console.WriteLine("Please Enter Special char:");
            char special = char.Parse(Console.ReadLine());
            Console.WriteLine($"Index of special character:{str.IndexOf(special)}");
            Console.ReadLine();
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////Find the index of special character using For loop//////////////////////////////////////
            /*  string str1 = "Csharp#";
              Console.WriteLine("Please Enter Special char:");
              char special1 = char.Parse(Console.ReadLine());
              for (int i = 0; i < str.Length; i++)
              {
                  if (str1[i] == special)
                  {
                      Console.WriteLine($"index of special character:{i}");
                  }
              }
              Console.ReadLine();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////CODE TO PRINT DUPLICATE CHAR FROM STRING and Count Them///////////////////////////////
            /*
                  string s = "aaaabbbbccccddddd";
                  int[] cal = new int[maxCHARS];
                  calcultes(s,cal);
                  for (int i = 0; i < maxCHARS; i++)

                      if (cal[i] > 1)
                      {
                          Console.WriteLine("Character " + (char)i);
                          Console.WriteLine("Occurance= " + cal[i] + " times");
                      }

              }
              static int maxCHARS = 256;
              static void calcultes(string s,int[] cal)
              {
                  for (int i=0;i<s.Length;i++)
                  {
                     cal[s[i]]++;
                  }
              }
              */



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////CODE TO COUNT OCCURANCE OF EACH CHARACTER///////////////////////////////
            /*
             string str = "Jayshree";
             Console.WriteLine("String:"+"=");
             while(str.Length>0)
             {
                 Console.Write(str[0]+"=");
                 int cal = 0;
                 for(int j=0;j<str.Length;j++)
                 {
                     if(str[0]==str[j])
                     {
                         cal++;
                     }
                 }
                 Console.WriteLine(cal);
                 str = str.Replace(str[0].ToString(),string.Empty);
             }

             Console.ReadLine();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////program to print addition of numbers from string from user"WINJIT123" o/p=1+2+3///////////////////////////////
            /*
            string str = "WINJIT123";
            var str1 = str.ToCharArray();  
            int sum = 0;
            Console.WriteLine(str1);
          
            for (int i = 0; i<str.Length-1; i++)
            {
                if (str1[i]>='0' && str1[i]<='9')
                {
                    sum += (str1[i]-'0');
                }
            }
            Console.WriteLine($"The Sum Of Digits: {sum}");
            Console.ReadLine();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////program to extract numbers present in the string ///////////////////////////////
            /*
            string str = "abhgfsd123jdhgk8976jkdhgsd34567jhgf2345";
            string str2 = string.Empty;
            Console.WriteLine(str);

            for (int i = 0; i < str.Length ; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    str2 += str[i];

                }
            }

            Console.WriteLine(str2);

            Console.ReadLine();
           */
        }

    }
}


