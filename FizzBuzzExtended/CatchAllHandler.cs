namespace FizzBuzzExtended
{
    public class CatchAllHandler : Handler, IRule
    {
        public override bool IsRuleMatched(int number)
        {
            return true;
        }

        public override string Print(int number)
        {
            return number.ToString();
        }
    }
}
