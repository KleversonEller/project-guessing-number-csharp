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
        return "---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
    }

    public string ChooseNumber(string userEntry)
    {
        var isConvert = int.TryParse(userEntry, out int convert);

        if(!isConvert) return "Entrada inválida! Não é um número.";
        if(convert < -100 || convert > 100) return "Entrada inválida! Valor não está no range.";

        userValue = convert;

        return "Número escolhido!";
    }

    public string RandomNumber()
    {
        var number = random.GetInt(-100, 100);

        randomValue = number;

        return "A máquina escolheu um número de -100 à 100!";
    }

    public string AnalyzePlay()
    {
        if(userValue > randomValue) return "Tente um número MENOR";
        else if(userValue < randomValue) return "Tente um número MAIOR";
        else return "ACERTOU!";
    }
}
