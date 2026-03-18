namespace JotaSystem.Sdk.Localization.Tests
{
    public class LanguageProviderTest
    {
        [Fact]
        public void DefaultLanguage_ShouldBe_PtBr()
        {
            Assert.Equal(Language.PtBr, LanguageProvider.DefaultLanguage);
        }


        [Fact]
        public void Use_ShouldReturnProvidedLanguage()
        {
            var result = LanguageProvider.Use(Language.EsEs);
            Assert.Equal(Language.EsEs, result);
        }

        [Fact]
        public void Use_ShouldReturnDefault_WhenNull()
        {
            var result = LanguageProvider.Use(null);
            Assert.Equal(Language.PtBr, result);
        }

        [Theory]
        [InlineData(Language.PtBr, "pt-BR")]
        [InlineData(Language.EnUs, "en-US")]
        [InlineData(Language.EsEs, "es-ES")]
        public void GetCode_ShouldReturnExpected(Language lang, string expected)
        {
            var result = LanguageProvider.GetCode(lang);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetCode_ShouldUseDefault_WhenNull()
        {
            var result = LanguageProvider.GetCode(Language.EsEs);
            Assert.Equal("es-ES", result);
        }
    }
}