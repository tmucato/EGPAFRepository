using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL
{
    public class Functions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Boolean IsDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch (Exception ex)
            {
                var a = ex;
                return false;
            }
        }

        public static string ConvertBoolToComboValue(bool value)
        {
            string result = string.Empty;

            try
            {
                if (value)
                {
                    result = "SIM";
                }
                else
                {
                    result = "NÃO";
                }

            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public static Nullable<bool> ConvertComboValueToBool(string value)
        {
            Nullable<bool> result = null;

            try
            {
                if (value == "SIM")
                {
                    result = true;
                }
                else if (value == "NÃO")
                {
                    result = false;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return result;

        }


    }
}
