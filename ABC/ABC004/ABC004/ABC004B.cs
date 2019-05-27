using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ABC004.B
{
    static class Class2
    {
        public static void ABC004B()
        {

        }
        
        public static T TryParse<T>(this string input)
        {
            try
            {
                var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(input);
                }
                else
                {
                    throw new InvalidCastException("");
                }
            }
            catch
            {
                throw new InvalidCastException(typeof(T) + " is not suported.");
            }
        }

        public static List<T> SplitTryParseToList<T>(this string input)
        {
            return input.Split().Select(n => n.TryParse<T>()).ToList();
        }
    }
}
