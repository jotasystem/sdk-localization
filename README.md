# JotaSystem.Sdk.Localization

Pacote de **internacionalização e localização (i18n/l10n)** da **Jota System**, responsável por centralizar mensagens traduzidas, resolução de idioma e serviços de tradução para aplicações .NET.

---
## 📦 Descrição

O **JotaSystem.Sdk.Localization** fornece a infraestrutura necessária para trabalhar com múltiplos idiomas de forma padronizada em APIs, serviços, aplicações web e demais soluções da plataforma Jota System.

O pacote permite armazenar e acessar mensagens traduzidas para diferentes culturas (como `pt-BR`, `en-US`, `es-ES`), oferecendo um mecanismo centralizado e extensível para resolver textos conforme o idioma configurado.

Inclui:
- **Serviço de localização** para obtenção de mensagens traduzidas.
- **Provedores de tradução** (via arquivos JSON ou outras fontes).
- **Detecção automática do idioma** via `CultureInfo`, cabeçalhos HTTP ou contexto da aplicação.
- **Fallback de idioma**, garantindo retorno mesmo quando a tradução estiver ausente.
- **Interfaces e abstrações** para permitir personalização e expansão.

---