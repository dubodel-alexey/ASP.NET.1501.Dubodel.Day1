using System;
using System.Collections.Generic;
using System.Globalization;

namespace Logic
{

    public class HexNumberFormat : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string fmt, object arg, IFormatProvider formatProvider)
        {
            // Provide default formatting for unsupported format strings.
            if ((fmt != "HEX") && (fmt != "hex"))
                try
                {
                    return HandleOtherFormats(fmt, arg);
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", fmt), e);
                }

            Type argType = arg.GetType();
            // Provide default formatting if arg is not an integer
            if (argType != typeof(Int16) && argType != typeof(Int32) && argType != typeof(Int64)
                && argType != typeof(byte) && argType != typeof(short) && argType != typeof(ushort)
                && argType != typeof(uint))
                try
                {
                    return arg.ToString();
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", fmt), e);
                }

            
            if (fmt == "HEX")
                return DecimalToHexSystem((dynamic)arg);
            if (fmt == "hex")
                return DecimalToHexSystem((dynamic)arg).ToLowerInvariant();
            return arg.ToString();
        }

        private string DecimalToHexSystem(long number)
        {
            const int bitsInLong = 64;
            const string digits = "0123456789ABCDEF";


            if (number == 0)
                return "0";

            int index = bitsInLong - 1;
            long currentNumber = Math.Abs(number);
            var charArray = new char[bitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % 16);
                currentNumber = currentNumber / 16;
                charArray[index--] = digits[remainder];
            }

            var result = new String(charArray, index + 1, bitsInLong - index - 1);
            if (number < 0)
            {
                result = "-" + result;
            }

            return result;
        }
        private string HandleOtherFormats(string format, object arg)
        {
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, CultureInfo.CurrentCulture);
            if (arg != null)
                return arg.ToString();
            return String.Empty;
        }
    }
}
