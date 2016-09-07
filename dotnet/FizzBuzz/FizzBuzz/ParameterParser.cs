namespace FizzBuzz
{
    public static class ParameterParser
    {
        public static int? GetValue(string[] args)
        {
            int? value = null;
            if (args != null && args.Length > 0)
            {
                int parsedValue;
                if (int.TryParse(args[0], out parsedValue))
                {
                    value = parsedValue;
                }
            }
            return value;
        }
    }
}