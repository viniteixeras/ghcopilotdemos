# GH Copilot Testes em C#

[![Build Validation](https://github.com/viniteixeras/ghcopilotdemos/actions/workflows/build-validation.yml/badge.svg)](https://github.com/viniteixeras/ghcopilotdemos/actions/workflows/build-validation.yml)

Este repositório contém um projeto C# web simples para testar e explorar as funcionalidades do GitHub Copilot.

## Como executar

1. Certifique-se de ter o .NET SDK instalado (.NET 8.0 ou superior).
2. No terminal, execute:
   ```powershell
   dotnet run
   ```
3. Abra seu navegador e acesse: `http://localhost:5000`

## Funcionalidade

A aplicação serve uma página HTML que exibe "Hello, World!" em um design responsivo e estilizado.

## Estrutura
- `Program.cs`: Código principal da aplicação web que serve HTML.
- `GH Copilot.csproj`: Configuração do projeto web.
- `.github/copilot-instructions.md`: Instruções personalizadas para o Copilot.

## Objetivo

Facilitar experimentos, sugestões e aprendizado com o GitHub Copilot em C#, agora com uma interface web visual.

## Build Validation

Este repositório inclui validação automática de build através do GitHub Actions que:
- ✅ Verifica a restauração de dependências
- ✅ Valida a compilação da aplicação
- ✅ Testa se a aplicação inicia corretamente
- ✅ Verifica se o endpoint principal responde adequadamente

A validação é executada automaticamente em todos os pushes e pull requests para as branches principais.
