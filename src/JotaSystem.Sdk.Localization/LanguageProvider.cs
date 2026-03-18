using System.Globalization;

namespace JotaSystem.Sdk.Localization
{
    public static class LanguageProvider
    {
        public static Language DefaultLanguage { get; private set; } = Language.PtBr; // Idioma padrão global do SDK

        public static Language Current()
        {
            var culture = CultureInfo.CurrentUICulture;
            return culture is null ? DefaultLanguage : FromCulture(culture);
        }

        // Usa o idioma informado ou o padrão
        public static Language Use(Language? lang = null)
            => lang ?? Current();

        // Converte CultureInfo ("pt-BR") para Language enum.
        public static Language FromCulture(CultureInfo culture)
            => FromCode(culture.Name);

        // Converte código "pt-BR" ou "pt" para Language.
        public static Language FromCode(string code)
        {
            return code.ToLower() switch
            {
                "pt-br" or "pt" => Language.PtBr,
                "en-us" or "en" => Language.EnUs,
                "es-es" or "es" => Language.EsEs,
                _ => DefaultLanguage,// fallback seguro
            };
        }

        // Retorna o código da cultura baseado no enum.
        public static string GetCode(Language? language = null)
        {
            return (language ?? DefaultLanguage) switch
            {
                Language.EnUs => "en-US",
                Language.EsEs => "es-ES",
                _ => "pt-BR"
            };
        }

        // Converte o enum Language para CultureInfo.
        public static CultureInfo ToCulture(Language? language = null)
            => new(GetCode(language));
    }
}