using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string MyGlobalVariable { get; set; } = "Hello";

        static void Main(string[] args)
        {
            #region String Type
            //string name = "orkhan";
            //Console.WriteLine(name);

            //string nameSurname = "  orkhan farajov   ";

            //nameSurname = nameSurname.TrimEnd();
            //nameSurname = nameSurname.TrimStart();
            //nameSurname = "  orkhan farajov   ";
            //nameSurname = nameSurname.Trim();

            //string upperCase = nameSurname.ToUpper();
            //Console.WriteLine("ToUpper: " + upperCase);

            //string lowerCase = nameSurname.ToLower();
            //Console.WriteLine("ToLower: " + lowerCase);

            //string substring = nameSurname.Substring(2, 4);
            //Console.WriteLine("Substring: " + substring);

            //bool startsWith = nameSurname.StartsWith("o");
            //Console.WriteLine("StartsWith 'o'? :" + startsWith.ToString());

            //bool endsWith = nameSurname.EndsWith("p");
            //Console.WriteLine("EndsWith 'p'? :" + endsWith.ToString());

            //int length = nameSurname.Length;
            //Console.WriteLine("Length: " + length);

            //bool contains = nameSurname.Contains('k');
            //Console.WriteLine("Contains k? :" + contains.ToString());

            //string[] split = nameSurname.Split(' ');
            //Console.WriteLine("Split 0: " + split[0]);
            //Console.WriteLine("Split 1: " + split[1]);

            //int indexOf = nameSurname.IndexOf('n');
            //Console.WriteLine("IndexOf 'n': " + indexOf);

            //bool equals = nameSurname.Equals("orkhan farajov");
            //Console.WriteLine("Equals: " + equals);
            #endregion

            #region Char Type
            //string a = "A";
            //string b = "B";
            //string c = "C";
            //string d = "D";
            //string e = "E";
            //string f = "F";
            //string g = "G";

            //char charA = 'A';
            //char charB = 'B';
            //char charC = 'C';
            //char charD = 'D';
            //char charE = 'E';
            //char charF = 'F';
            //char charG = 'G';

            char charSymbol = '%';
            //char whiteSpace = ' ';

            //var stringToLower = a.ToLower();
            //var toLower = char.ToLower(charA);
            //var toUpper = char.ToUpper(charB);
            //var isUpper = char.IsUpper(charA);
            //var isLower = char.IsLower(charA);
            //var isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            var isSymbol = char.IsSymbol(charSymbol);
            //var isDigit = char.IsDigit('4');
            //var isDigit2 = char.IsDigit(charG);
            //var isNumber = char.IsNumber('1');
            //var isLetter = char.IsLetter(charC);
            #endregion

            #region Byte Type
            byte byteVariable = 49;
            byte byteMinValue = byte.MinValue; //0
            byte byteMaxValue = byte.MaxValue; //255
            #endregion

            #region Byte Type
            sbyte sbyteVariable = 127;
            sbyte sbyteMinValue = sbyte.MinValue; //-128
            sbyte sbyteMaxValue = sbyte.MaxValue; //127
            #endregion

            #region Short, Int, Long Types
            //həcmi:
            //int16: 2byte (short)
            //int32: 4byte (int)
            //int64: 8byte (long)
            
            short shortMinValue = short.MinValue;
            short shortMAxValue = short.MaxValue;
            short shortValue = 28500;
            short shortValueNegative = -26511;

            int intMinValue = int.MinValue;
            int maxValue = int.MaxValue;
            int integer = 2458745;
            int integerValueNegative = -222151;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 215615641156181561;
            long longValueNegative = -215615641156181;
            #endregion

            #region Double Type
            double doubleVar = 10.2;
            double doubleVar2 = 2;
            double doubleVar3 = 10.8d;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            double nan = 0.0 / 0.0;
            double notNan = 5 / 2.5;
            bool resultOfNan = double.IsNaN(nan);
            bool resultOfNotNan = double.IsNaN(notNan);
            
            double infinity = 0.1 / 0.0;
            double notInfinity = 0.0 / 0.0;
            bool resultOfinfinityn = double.IsInfinity(infinity);
            bool resultOfNotInfinity = double.IsInfinity(notInfinity);

            double epl = double.Epsilon;
            double epilsonValue = 4.94065645841247E-324;
            double one = 1;
            bool whichIsGrater = one > epilsonValue;
            #endregion

            #region Decimal Type
            decimal decimalVar = 50.6m;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            var minusOne = decimal.MinusOne;
            //500
            //var decimalToByte =  decimal.ToByte(500);
            //var decimalToSByte = decimal.ToSByte(500);
            short decimalToShort = decimal.ToInt16(500);
            int decimalToInt = decimal.ToInt32(26261225);
            long decimalToLong = decimal.ToInt64(51561561561656156);

            #endregion

            #region Float Type
            float floatVar = 10.4f;

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            #endregion

            #region Boolean Type
            bool booleanVar = true;
            booleanVar = false;

            bool defaultBooleanValue;
            defaultBooleanValue = true;

            string _true = bool.TrueString;
            string _false = bool.FalseString;
            #endregion

            #region DateTime Type
            DateTime now = DateTime.Now;
            DateTime utc = DateTime.UtcNow;

            var ticks = now.Ticks;
            var milliSecond = now.Millisecond;
            var second = now.Second;
            var minute = now.Minute;
            var hour = now.Hour;
            var day = now.Day;
            var dayOfWeek = now.DayOfWeek;
            var month = now.Month;
            var year = now.Year;
            var timeOfDay = now.TimeOfDay;
            var toShortDateString = now.ToShortDateString();
            var toLongDateString = now.ToLongDateString();
            var toShortTimeString = now.ToShortTimeString();
            var toLongTimeString = now.ToLongTimeString();
            var timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
            var timeFormat2 = now.ToString("MMMM dd");
            var timeFormat3 = now.ToString("dddd, dd MMMM yyyy");
            var timeFormat4 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            var timeFormat5 = now.ToString("HH:mm");
            var timeFormat6 = now.ToString("H:mm");
            var timeFormat7 = now.ToString("hh:mm");
            var timeFormat8 = now.ToString("ddd, dd MMM yyy HH:mm:ss");

            var monthChanged = now.AddMonths(2);
            var monthChangedAgain = now.AddMonths(-2);
            var dayChanged = now.AddDays(2);
            var hourChanged = now.AddHours(4);
            var minsChanged = now.AddMinutes(15);
            var secondsChanged = now.AddSeconds(20);
            var millisecondsChanged = now.AddMilliseconds(20);
            #endregion

            #region Object Type
            object textObj = "Orkhan";
            object integerObj = 18;
            object booleanObj = true;
            object decimalObj = 15.2M;
            object dateTimeObj = new DateTime();

            Console.WriteLine(textObj);
            Console.WriteLine(integerObj);
            Console.WriteLine(booleanObj);
            Console.WriteLine(decimalObj);
            Console.WriteLine(dateTimeObj);
            #endregion

            #region Default values of data types
            var x = 4;
            //referance-types
            string defaultOfString;
            object defaultOfObject;
            Student student = new Student();
            //value-types
            char defaultOfChar;
            byte defaultOfByte;
            short defaultOfShort;
            int defaultOfInt;
            long defaultOfLong;
            double defaultOfDouble;
            decimal defaultOfDecimal;
            float defaultOfFloat;
            bool defaultOfBoolean;
            DateTime defaultOfDateTime;

            Console.ReadLine();
            #endregion

            #region Local and Global variables
            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);
            Console.WriteLine(MyGlobalVariable);

            //local variable to global
            //int globalVar;

            //{
            //    int localVar = 555;
            //    globalVar = localVar;
            //}

            //{
            //    Student localStudent = new Student();
            //    localStudent.Age = globalVar;
            //}

            

            { //Level 4
                int level4 = 90000000; //Putin
                { //Level 3
                    int level3 = 10000000; //Zaur

                    level4 -= 1000000;

                    { //Level 2
                        int level2 = 100000; //Ruslan
                        
                        level3 -= 500;

                        level3 -= 10000;

                        { //Level 1
                            int level1 = 150; //Orxan

                            level4 -= 2000000;
                            level3 -= 5000;
                            level2 -= 500;
                        }
                    }
                }
            }

            

            //localVariableInScope = 2;
            #endregion
        }

        public static void otherMethod()
        {
            Console.WriteLine(MyGlobalVariable);
        }
    }

    public class Student
    {
        public int Age { get; set; }
    }
}