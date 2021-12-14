using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeAndReferenceType
{
    class Program
    {
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
            //Console.WriteLine("StartsWith 'o'? :" + startsWith);

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

            //char charSymbol = '*';
            //char whiteSpace = ' ';

            //var stringToLower = a.ToLower();
            //var toLower = char.ToLower(charA);
            //var toUpper = char.ToUpper(charB);
            //var isUpper = char.IsUpper(charA);            
            //var isLower = char.IsLower(charA);

            //var isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            //var isSymbol = char.IsSymbol(charSymbol);
            //var isDigit = char.IsDigit('4');
            //var isDigit2 = char.IsDigit(charG);
            //var isNumber = char.IsNumber('1');
            //var isLetter = char.IsLetter(charC);
            #endregion

            #region Byte Type
            byte byteVariable = 49;
            byte byteMinValue = byte.MinValue; //0
            byte byteMaxValue = byte.MaxValue; //255
            //Console.WriteLine(byteMaxValue);
            //Console.WriteLine(byteMinValue);
            #endregion

            #region Byte Type
            sbyte sbyteVariable = 127;
            sbyte sbyteMinValue = sbyte.MinValue; //-128
            sbyte sbyteMaxValue = sbyte.MaxValue; //127
            //Console.WriteLine(sbyteMaxValue);
            //Console.WriteLine(sbyteMinValue);
            #endregion

            #region Short, Int, Long Types
            //həcmi:
            //int16: 2byte (short)
            //int32: 4byte (int)
            //int64: 8byte (long)

            short shortMinValue = short.MinValue; //-32768
            short shortMAxValue = short.MaxValue; //32767
            //Console.WriteLine(shortMAxValue);
            //Console.WriteLine(shortMinValue);
            short shortValue = 28500;
            short shortValueNegative = -26511;

            int intMinValue = int.MinValue; //-2147483648
            int intMaxValue = int.MaxValue; // 2147483647
            //Console.WriteLine(intMinValue);
            //Console.WriteLine(intMaxValue);
            int integer = 2458745;
            int integerValueNegative = -222151;

            long longMinValue = long.MinValue; // -9223372036854775808
            long longMaxValue = long.MaxValue; //  9223372036854775807
            long longValue = 215615641156181561;
            long longValueNegative = -215615641156181;
            #endregion

            #region Double Type
            double doubleVar = 10.2;
            double doubleVar2 = 2;
            double doubleVar3 = 10.8d;

            double doubleMinValue = double.MinValue; // -1,79769313486232E + 308
            double doubleMaxValue = double.MaxValue; //  1,79769313486232E + 308
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);

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

            decimal decimalMinValue = decimal.MinValue; //-79228162514264337593543950335
            decimal decimalMaxValue = decimal.MaxValue; // 79228162514264337593543950335
            //Console.WriteLine(decimalMinValue);
            //Console.WriteLine(decimal.MaxValue);

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

            float floatMinValue = float.MinValue; //-3,402823E+38
            float floatMaxValue = float.MaxValue; // 3,402823E+38
            //Console.WriteLine(floatMaxValue);
            //Console.WriteLine(floatMinValue);
            #endregion

            #region Boolean Type
            bool booleanVar = true;
            booleanVar = false;

            bool defaultBooleanValue;
            defaultBooleanValue = true;

            string _true = bool.TrueString;
            string _false = bool.FalseString;
            //Console.WriteLine(_true);
            //Console.WriteLine(_false);
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
        }
    }
}
