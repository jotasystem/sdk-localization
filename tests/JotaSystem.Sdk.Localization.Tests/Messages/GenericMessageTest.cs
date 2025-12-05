using JotaSystem.Sdk.Localization.Messages;

namespace JotaSystem.Sdk.Localization.Tests.Messages
{
    public class GenericMessageTest
    {
        [Theory]
        [InlineData(Language.PtBr, "Operação inválida: Teste.")]
        [InlineData(Language.EnUs, "Invalid operation: Teste.")]
        [InlineData(Language.EsEs, "Operación inválida: Teste.")]
        public void InvalidPattern_ShouldReturnLocalizedMessage(Language lang, string expected)
        {
            var message = GenericMessage.InvalidOperation("Teste", lang);
            Assert.Equal(expected, message);
        }
    }
}
