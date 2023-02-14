using Xunit;
using System;
using FluentAssertions;

namespace guessing_number.Test.Test;

[Collection("Sequential")]
public class TestPrintInitialMessageSuccess
{
    [Trait("Category", "1 - Imprima uma mensagem de saudação e seu teste")]
    [Theory(DisplayName = "TestGreet deve ser executado com sucesso quando printar a saudação")]
    [InlineData("---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!")]
    public void TestSucessTestGreet(string entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestGreet(entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Imprima uma mensagem de saudação e seu teste")]
    [Theory(DisplayName = "TestGreet deve falhar com sucesso quando não printar a saudação")]
    [InlineData("---Bem-vindo ao Guessing Game--- Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!")]
    [InlineData("---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei")]
    [InlineData("Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!")]
    public void TestFailTestGreet(string entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestGreet(entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndConvertSuccess
{
    [Trait("Category", "2 - Receba a entrada da pessoa usuária e converta para Int")]
    [Theory(DisplayName = "TestReceiveUserInputAndConvert deve ser executado com sucesso quando receber a entrada correta")]
    [InlineData("10", 10)]
    [InlineData("20", 20)]
    [InlineData("-99", -99)]
    [InlineData("-45", -45)]
    [InlineData("0", 0)]
    public void TestSucessTestReceiveUserInputAndConvert(string entry, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndConvert(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Receba a entrada da pessoa usuária e converta para Int")]
    [Theory(DisplayName = "TestReceiveUserInputAndConvert deve falhar quando receber a entrada errada")]
    [InlineData("9", 10)]
    [InlineData("-20", 20)]
    [InlineData("99", -99)]
    [InlineData("45", -45)]
    [InlineData("0", 1)]
    public void TestFailTestReceiveUserInputAndConvert(string entry, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndConvert(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Receba a entrada da pessoa usuária e converta para Int")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyType deve executar com sucesso quando receber a entrada correta")]
    [InlineData("1sony0")]
    [InlineData("")]
    [InlineData("teste")]
    [InlineData("alala")]
    [InlineData("trybe")]
    [InlineData("trybe2")]
    public void TestSucessTestReceiveUserInputAndVerifyType(string entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyType(entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Receba a entrada da pessoa usuária e converta para Int")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyRange deve executar com sucesso quando receber a entrada correta")]
    [InlineData("1000")]
    [InlineData("-1000")]
    [InlineData("-101")]
    [InlineData("101")]
    [InlineData("9999")]
    public void TestSucessTestReceiveUserInputAndVerifyRange(string entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyRange(entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
