namespace FizzBuzzExtended
{
    public abstract class Handler : IRule
    {
        Handler _nextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public string HandleRequest(int number)
        {
            return IsRuleMatched(number) ? Print(number) : _nextHandler.HandleRequest(number);
        }

        public abstract string Print(int number);
        public abstract bool IsRuleMatched(int number);
    }
}
