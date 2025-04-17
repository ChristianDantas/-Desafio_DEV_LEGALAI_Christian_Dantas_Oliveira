Segue abaixo um exemplo de **README.md** contendo as instruções pedidas:

---

```markdown
# Desafio DEV LEGALAI do Christian Dantas Oliveira

Este projeto consiste em um sistema desenvolvido com **ASP.NET** e **ASP.NET Core**. A seguir, você encontrará as instruções necessárias para configurar o ambiente, rodar o banco de dados, compilar o projeto e utilizar o front-end.

## Requisitos

- **SQL Server**  
- **ASP.NET**  
- **ASP.NET Core**

## Passo a Passo

### 1. Instale e Configure o SQL Server

- **Baixe o SQL Server**: Certifique-se de instalar a versão adequada para o seu ambiente.  
- **Configuração de Autenticação**: Durante a instalação, configure o SQL Server para utilizar **autenticação Windows**.

### 2. Execute os Scripts SQL

- **Localize a Pasta "Banco de Dados"**: Dentro do repositório, identifique a pasta onde estão os arquivos DDL e DML.  
- **Rode os Scripts**: 
  - **DDL** (Data Definition Language): Executa os scripts para criar a estrutura do banco (tabelas, relacionamentos, etc.).
  - **DML** (Data Manipulation Language): Executa os scripts para inserir os dados iniciais.

### 3. Configure a String de Conexão

- **Arquivos a Serem Editados**:  
  Navegue até os seguintes arquivos:
  - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\EmpresaRepository`
  - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\InteresseRepository`
  - `Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira\backend\-Desafio_DEV_LEGALAI\-Desafio_DEV_LEGALAI\Repositores\UsuarioRepository`

- **Altere a String de Conexão**:  
  Em cada um desses arquivos, localize a linha 8 que contém:

  ```csharp
  private string stringConexao = "Data Source=DESKTOP-P4LGFHE;initial catalog=Desafio_Legal;integrated security=true";
  ```

  Atualize o valor de `Data Source` para o nome do servidor onde você criou o banco de dados.  
  **Exemplo**: Se você estiver rodando o banco localmente, substitua `DESKTOP-P4LGFHE` pelo nome do seu desktop.

### 4. Compile o Projeto

- Certifique-se de que o backend está funcionando corretamente.  
- Compile o arquivo `program.cs` para validar todas as configurações e garantir que o projeto foi iniciado sem erros.

### 5. Configure e Utilize o Front-End

- **Abra o Arquivo `page1.html`**:  
  Utilize este arquivo para acessar o formulário e fazer o seu perfil.

- **Abra o Arquivo `page2.html`**:  
  Após completar seu perfil, acesse `page2.html` para visualizar o seu match com a empresa, de acordo com os dados configurados no projeto.

## Considerações Finais

- **Tecnologias Utilizadas**: O projeto foi desenvolvido utilizando **ASP.NET** e **ASP.NET Core**.
- **Sugestões de Melhoria**:  
  - Integração com um banco de dados na nuvem, a fim de reduzir problemas que possam ocorrer com a compilação ou mudanças no ambiente local.
  - Aperfeiçoamento da função de match entre usuários e empresas.
- Caso você encontre dificuldades na compilação devido às versões dos frameworks ou configurações do ambiente local, disponibilizarei imagens ilustrativas do HTML em funcionamento.

Agradeço pela atenção e espero que essa experiência seja enriquecedora. Se algo não estiver totalmente claro ou se surgirem dúvidas, por favor, sinta-se à vontade para entrar em contato!
```
