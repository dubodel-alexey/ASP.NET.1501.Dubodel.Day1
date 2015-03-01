using System;
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
            // Provide default formatting if arg is not an Int32.
            if (argType != typeof(Int16) && argType != typeof(Int32) && argType != typeof(Int64)
                && argType != typeof(byte) && argType != typeof(short) && argType != typeof(decimal) 
                && argType != typeof(ushort) && argType != typeof(ulong) && argType != typeof(uint))
                try
                {
                    return arg.ToString();
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", fmt), e);
                }

            
            if (fmt == "HEX")
                return ((dynamic)arg).ToString("X");
            if (fmt == "hex")
                return ((dynamic)arg).ToString("x");
            return arg.ToString();
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
