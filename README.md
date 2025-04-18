
# Desafio DEV LEGAL AI - Christian Dantas Oliveira

## Funcionalidades

- Consumo dos dados dos endpoints de **Usuários** e **Empresas**.
- Agrupamento dos cards de acordo com o interesse.
- Definição de “match” quando há pelo menos uma Empresa e um Usuário dentro do mesmo grupo.
- Geração de uma porcentagem que varia conforme o status de match.

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão compatível com o projeto)

## Instalação

1. **Clone o Repositório**

   Abra o terminal e execute:
   ```bash
   git clone https://github.com/ChristianDantas/-Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira.git
   ```

2. **Navegue até a Pasta do Projeto**
   ```bash
   cd -Desafio_DEV_LEGALAI_Christian_Dantas_Oliveira
   ```

## Execução

Para compilar e executar seu aplicativo, siga os passos abaixo:

1. **Abra o Terminal** na pasta onde se encontra o arquivo de projeto (o arquivo `.csproj`).
2. **Execute o Projeto**  
   Utilize o comando:
   ```bash
   dotnet run
   ```
   O programa irá compilar (se necessário) e rodar, iniciando o código presente em `Program.cs` que fará as chamadas às APIs de Usuários e Empresas, agrupará os dados pelos interesses e exibirá os cards agrupados conforme o status de match.

## Estrutura do Projeto

- **Program.cs**  
  Ponto de entrada da aplicação onde é executada a lógica principal (consumo de APIs, agrupamento e renderização dos cards).

- **Outros diretórios e arquivos**  
  Organize os demais arquivos conforme necessário. Este repositório serve como base para o desafio DEV LEGAL AI.

## Contribuição

Contribuições são bem-vindas! Para contribuir:

1. Faça um fork do repositório.
2. Crie uma nova branch:
   ```bash
   git checkout -b minha-feature
   ```
3. Faça suas modificações e em seguida commit:
   ```bash
   git commit -m "Descrição da nova feature"
   ```
4. Envie para sua branch:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request para o repositório original.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

## Contato

Para dúvidas, sugestões ou contribuições, entre em contato por meio do GitHub ou envie um e-mail para [Christian_d_ol9000@hotmail.com](mailto:Christian_d_ol9000@hotmail.com).
```

Este README.md pode ser adicionado ao repositório para orientar desenvolvedores a instalar, executar e contribuir com o projeto.
