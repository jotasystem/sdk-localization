# JotaSystem.Sdk.Localization

Biblioteca simples de localização da **Jota System** para aplicações .NET.

## Descrição

O `JotaSystem.Sdk.Localization` fornece uma camada leve para resolução de idioma e geração de mensagens padronizadas em múltiplas culturas.

Hoje o pacote contém:

- Enum `Language` com suporte atual a `pt-BR`, `en-US` e `es-ES`.
- `LanguageProvider` para converter cultura, código de idioma e idioma padrão do SDK.
- Classes de mensagens estáticas para validação, datas, números, regex e mensagens genéricas.

## Escopo atual

Este pacote não usa arquivos JSON, banco de dados ou mecanismo externo de tradução. As mensagens são mantidas diretamente em código, com fallback para o idioma padrão.

## Quando usar

Use este SDK quando a aplicação precisar padronizar mensagens técnicas ou de validação em mais de um idioma, sem depender de uma infraestrutura completa de i18n.
