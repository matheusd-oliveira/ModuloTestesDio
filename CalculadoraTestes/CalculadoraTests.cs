namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);


    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);


    }

    [Fact]
    public void DeveRetornarTrueSeForPar()
    {
        // Arrange
        int num1 = 4;
        int num2 = 5;

        // Act
        bool resultado1 = _calc.EhPar(num1);
        bool resultado2 = _calc.EhPar(num2);

        // Assert
        Assert.Equal(true, resultado1);
        Assert.Equal(false, resultado2);
    }

}