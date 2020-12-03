using System;

namespace WCFClient.Client
{
    public static class DataExtensions
    {
        public static bool IsNull(this object obj) => obj is null;

        public static object CheckDBNull(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return DBNull.Value;
            }
            else
            {
                return str;
            }
        }
    }
}
