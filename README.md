# README - Instruções para Configuração e Execução do Projeto

## Introdução
Este documento fornece instruções detalhadas para configurar e executar o projeto "Desafio DEV LEGALAI". O projeto é desenvolvido em ASP.NET e ASP.NET Core, e utiliza um banco de dados SQL Server.

## Pré-requisitos
Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:
- SQL Server (Versão compatível com o projeto)
- Visual Studio com suporte para .NET (ou Visual Studio Code com C# e .NET Core SDK)

## Passo a Passo

### 1. Download e Configuração do SQL Server
1. Baixe e instale o SQL Server a partir do site oficial da Microsoft.
2. Durante a instalação, escolha a opção de autenticação do Windows.

### 2. Rote os Arquivos DDL e DML
1. Localize a pasta `banco de dados` em seu projeto.
2. Execute os scripts de DDL (Data Definition Language) e DML (Data Manipulation Language) para criar e popular as tabelas necessárias no banco de dados.

### 3. Atualização das Conexões
Após configurar o banco de dados:
1. Navegue até os arquivos de repositórios nos diretórios:
   - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\EmpresaRepository`
   - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\InteresseRepository`
   - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\UsuarioRepository`
   
2. Localize a seguinte linha no arquivo:
   ```csharp
   private string stringConexao = "Data Source=DESKTOP-P4LGFHE;initial catalog=Desafio_Legal;integrated security=true";
   ```
3. Substitua `DESKTOP-P4LGFHE` pelo nome do seu computador ou o nome do servidor onde o banco de dados foi criado. Exemplo:
   ```csharp
   private string stringConexao = "Data Source=SEU_NOME_DE_COMPUTADOR;initial catalog=Desafio_Legal;integrated security=true";
   ```

### 4. Compilação do Projeto
1. Abra o arquivo `Program.cs` em seu ambiente de desenvolvimento.
2. Compile o projeto para verificar se não há erros.

### 5. Configuração do Frontend
1. Navegue até o diretório que contém o arquivo `page1.html`.
2. Abra `page1.html` em seu navegador e crie seu perfil conforme necessário.

### 6. Visualização do Match
1. Após completar seu perfil, abra `page2.html`.
2. Aqui você poderá visualizar seu match com a empresa.

## Observações Finais
- Certifique-se de que o SQL Server esteja rodando e que você tenha permissões adequadas para acessar o banco de dados.
- Em caso de dúvidas ou problemas, consulte a documentação do ASP.NET ou entre em contato com a equipe de suporte.

## Conclusão
Com estas instruções, você deverá conseguir configurar e rodar o projeto sem dificuldades. Boa sorte e divirta-se desenvolvendo!

--- 

Se precisar de mais assistência ou tiver outras perguntas, fique à vontade para pedir!