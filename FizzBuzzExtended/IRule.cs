namespace FizzBuzzExtended
{
    public interface IRule
    {
        bool IsRuleMatched(int number);
        string Print(int number);
    }
}
