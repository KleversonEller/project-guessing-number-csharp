using Xunit;
using System.IO;
using System;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory(DisplayName = "Deve exibir mensagem inicial!")]
    [InlineData("---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!")]
    public void TestGreet(string expected)
    {
        GuessNumber result = new();

        result.Greet().Should().Be(expected);
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("10", 10)]
    [InlineData("20", 20)]
    [InlineData("30", 30)]
    [InlineData("-99", -99)]
    [InlineData("-45", -45)]
    [InlineData("0", 0)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {
        GuessNumber instance = new();

        var result = instance.ChooseNumber(entry);

        instance.userValue.Should().Be(expected);
        result.Should().Be("Número escolhido!");
    }

    [Theory(DisplayName = "Deve retornar mensagem de errro quando entrada não for inteiro.")]
    [InlineData("1sony0")]
    [InlineData("")]
    [InlineData("teste")]
    [InlineData("alala")]
    [InlineData("trybe")]
    public void TestReceiveUserInputAndVerifyType(string entry)
    {
        GuessNumber instance = new();

        var result = instance.ChooseNumber(entry);

        instance.userValue.Should().Be(0);
        result.Should().Be("Entrada inválida! Não é um número.");
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData("1000")]
    [InlineData("-1000")]
    [InlineData("-101")]
    [InlineData("101")]
    [InlineData("9999")]
    public void TestReceiveUserInputAndVerifyRange(string entry)
    {
        GuessNumber result = new();

        result.ChooseNumber(entry).Should().Be("Entrada inválida! Valor não está no range.");
    }
}
