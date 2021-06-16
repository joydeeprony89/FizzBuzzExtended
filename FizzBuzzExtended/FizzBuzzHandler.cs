namespace FizzBuzzExtended
{
    public class FizzBuzzHandler : Handler
    {
        public override bool IsRuleMatched(int number)
        {
            return number % 15 == 0;
        }

        public override string Print(int number)
        {
            return "FIZZBUZZ";
        }
    }
}
