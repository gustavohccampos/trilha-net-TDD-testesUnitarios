
using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraOperacoes _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraOperacoes();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void Somar(int val1, int val2, int result)
    {
        //act -  ja tem cenario e executar ação
        int resultadoCalc = _calc.Somar(val1, val2);
        //assert - validar se tem resultado esperado
        Assert.Equal(result, resultadoCalc);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    [InlineData(10, 5, 5)]
    public void Subtrair(int val1, int val2, int result)
    {
        //act -  ja tem cenario e executar ação
        int resultadoCalc = _calc.Subtrair(val1, val2);
        //assert - validar se tem resultado esperado
        Assert.Equal(result, resultadoCalc);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    [InlineData(10, 5, 50)]
    public void Multiplicar(int val1, int val2, int result)
    {
        //act -  ja tem cenario e executar ação
        int resultadoCalc = _calc.Multiplicar(val1, val2);
        //assert - validar se tem resultado esperado
        Assert.Equal(result, resultadoCalc);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(20, 2, 10)]
    [InlineData(100, 5, 20)]
    public void Dividir(int val1, int val2, int result)
    {
        //act -  ja tem cenario e executar ação
        int resultadoCalc = _calc.Dividir(val1, val2);
        //assert - validar se tem resultado esperado
        Assert.Equal(result, resultadoCalc);
    }

    [Fact]
    public void DividirPorZero() 
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
            );
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Somar(2, 3);
        _calc.Somar(3, 4);
        _calc.Somar(4, 5);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    
    }
}