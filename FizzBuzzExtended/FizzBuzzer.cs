﻿namespace FizzBuzzExtended
{
    public class FizzBuzzer
    {
        private Handler _firstHandler = null;

        public FizzBuzzer()
        {
            AddHandler(new CatchAllHandler());
            AddHandler(new BuzzHandler());
            AddHandler(new FizzHandler());
            AddHandler(new FizzBuzzHandler());
        }

        private void AddHandler(Handler previousHandler)
        {
            previousHandler.SetNextHandler(_firstHandler);
            _firstHandler = previousHandler;
        }

        public string HandleNumber(int number)
        {
            return _firstHandler.HandleRequest(number);
        }
    }
}
