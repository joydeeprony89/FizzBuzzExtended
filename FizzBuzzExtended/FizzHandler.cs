namespace FizzBuzzExtended
{
    public class FizzHandler : Handler
    {
        public override bool IsRuleMatched(int number)
        {
            return number % 3 == 0;
        }

        public override string Print(int number)
        {
            return "FIZZ";
        }
    }
}
