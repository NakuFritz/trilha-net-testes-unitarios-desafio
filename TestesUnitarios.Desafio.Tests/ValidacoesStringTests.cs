using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Corrigido o texto e resultado esperado

        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Corrigido a chamada do método para ContemCaractere e o Assert com base no retorno do método
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado); // Valida que o texto contém a palavra "qualquer"
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Corrigido o Assert para validar o resultado esperado
        // Assert
        Assert.False(resultado); // Valida que o texto não contém a palavra "teste"
    }

    [Fact] // Corrigido para [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Corrigido o textoProcurado
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado); // Valida que o texto termina com a palavra "procurado"
    }
}
