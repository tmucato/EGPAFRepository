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
        public static int ConvertComboConsultToNumb(string value)
        {
            int result = 0;
            try
            {
                switch (value)
                {
                    case "1ª":
                        result = 1;
                        break;
                    case "2ª":
                        result = 2;
                        break;
                    case "3ª":
                        result = 3;
                        break;
                    case "4ª":
                        result = 4;
                        break;
                    case "5ª":
                        result = 5;
                        break;
                    case "6ª":
                        result = 6;
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public static string ConvertNumbComboConsult(int value)
        {
            string result = string.Empty;
            try
            {
                switch (value)
                {
                    case 1:
                        result = "1ª";
                        break;
                    case 2:
                        result = "2ª";
                        break;
                    case 3:
                        result = "3ª";
                        break;
                    case 4:
                        result = "4ª";
                        break;
                    case 5:
                        result = "5ª";
                        break;
                    case 6:
                        result = "6ª";
                        break;
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
