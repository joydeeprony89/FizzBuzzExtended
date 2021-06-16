namespace FizzBuzzExtended
{
    public class BuzzHandler : Handler, IRule
    {
        public override bool IsRuleMatched(int number)
        {
            return number % 5 == 0;
        }

        public override string Print(int number)
        {
            return "BUZZ";
        }
    }
}
