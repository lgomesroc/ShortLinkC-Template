# ShortLinkC# - Encurtador de link básico em C#

Este projeto é um encurtador de links simples desenvolvido em C# usando o .NET 8.0. O objetivo é permitir que os usuários insiram uma URL longa e recebam uma URL encurtada que redireciona para a URL original.

## Estrutura do Projeto

```ardino
ShortLinkC#/
├── Controllers/
│   └── LinkController.cs   # Controlador para gerenciar as operações de encurtamento de links. 
├── wwwroot/
│   └── index.html          # Página HTML para a interface do usuário.
├── Program.cs              # Arquivo principal da aplicação, configura o servidor e o middleware.
└── ShortLinkC.csproj       # Arquivo de projeto do .NET.
```

## Funcionalidades Implementadas

1. **Interface do Usuário**:
   - Uma página HTML simples (`index.html`) onde os usuários podem inserir uma URL longa para encurtamento.
   - Um formulário que coleta a URL original e exibe a URL encurtada.

2. **Redirecionamento de URL**:
   - Quando um usuário acessa a URL encurtada, a aplicação redireciona para a URL original.
   - A aplicação usa um controlador (`LinkController.cs`) para gerenciar o encurtamento e o redirecionamento.

3. **Configuração do Servidor**:
   - O projeto utiliza o middleware do ASP.NET para servir arquivos estáticos a partir da pasta `wwwroot`.
   - A aplicação escuta na porta `5093` por padrão.

## Como Executar o Projeto

1. Clone o repositório ou faça o download do projeto.
2. Abra um terminal e navegue até o diretório do projeto.
3. Execute o seguinte comando para iniciar a aplicação:

```bash
   dotnet run
```
    Abra um navegador e acesse [http://localhost:5093/](http://localhost:5093/) para visualizar a interface do usuário.

# Tecnologias Utilizadas

    **C#**
    **.NET 8.0**
    **ASP.NET Core**
    **HTML**

# Possíveis Melhorias Futuras

    Implementar um sistema de armazenamento para manter os links encurtados e suas correspondências.
    Adicionar autenticação para usuários, permitindo o rastreamento de links encurtados.
    Criar uma interface mais rica e interativa usando JavaScript ou um framework front-end.

# Contribuições

Sinta-se à vontade para contribuir com melhorias, sugestões ou correções. Para isso, você pode criar uma nova branch, fazer suas alterações e submeter um pull request.

# Licença

Este projeto é licenciado sob a MIT License. Veja o arquivo LICENSE para mais detalhes.
