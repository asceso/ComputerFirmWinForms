namespace WCFServer
{
    public static class StringExtension
    {
        public static bool ToBool(this string str)
        {
            bool result = false;
            if (str.Equals("True") || str.Equals("true") || str.Equals("Yes") || str.Equals("no"))
            {
                result = true;
            }

            if (str.Equals("False") || str.Equals("false") || str.Equals("No") || str.Equals("no"))
            {
                result = false;
            }

            return result;
        }
    }
}
