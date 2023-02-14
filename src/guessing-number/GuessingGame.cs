using System;

namespace guessing_number;

public class GuessNumber
{
    //In this way we are passing the random number generator by dependency injection
    private IRandomGenerator random;
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;

        userValue = 0;
        randomValue = 0;
    }

    //user variables
    public int userValue;
    public int randomValue;


    public string Greet()
    {
        throw new NotImplementedException();
    }

    public string ChooseNumber(string userEntry)
    {
        throw new NotImplementedException();
    }

    public string RandomNumber()
    {
        throw new NotImplementedException();
    }

    public string AnalyzePlay()
    {
        throw new NotImplementedException();
    }
}
