namespace FizzBuzz
{
    public static class FizzBuzz
    {

        public const string ArgumnentIsNullMessage = "You must pass a numeric value as a parameter";


        public static string GetResult(int value)
        {
            var result = value.ToString();

            var isMultipleOf3 = value%3 == 0;
            var isMultipleOf5 = value%5 == 0;

            if (isMultipleOf3 && isMultipleOf5)
            {
                result = "FizzBuzz";
            }
            else if (value%3 == 0)
            {
                result = "Fizz";
            }
            else if (value%5 == 0)
            {
                result = "Buzz";
            }
            return result;
        }
    }
}