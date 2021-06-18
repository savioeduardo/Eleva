## Eleva

### Desafio

> A prefeitura de uma cidade no interior do país está com dificuldades para controlar suas escolas públicas. Já existe um controle feito em Excel para controle das escolas e suas turmas, porém, o cadastro está sempre obsoleto por não existir um sistema centralizado de controle destes alunos. A prefeitura então nos contratou para desenvolver um sistema online onde serão cadastradas as escolas públicas e suas respectivas turmas.
<br><br> Foi especificado que o sistema será composto por 2 ferramentas: uma para listagem/cadastro das escolas, e outra para o cadastro/listagem das turmas de cada escola. 
<br><br> O sistema deverá seguir os preceitos básicos da engenharia de software e Orientação a Objetos, com foco em qualidade, beleza e usabilidade, bem como utilizar as bibliotecas javascript mais modernas do mercado:

### Solução
A solução para o desafio proposto foi desenvolvida utilizando as tecnologias:
- Angular: 12.0.4;
- TypeScript: 4.2.3;
- Dotnet;
- EntityFramework;
- SqlLite;

A solução está divida em dois diretórios:
- Eleva: Aplicação em Angular;
- Eleva-WepAPI: Aplicação em Dotnet;

#### Angular
Comandos para executar a aplicação em Angular(Eleva):
```sh
cd Eleva
npm i
npm start
``` 
A aplicação estará rodando na porta 4200. Feito isso, basta acessar: `http://localhost:4200/`

#### Dotnet
Comandos para executar a aplicação em DotNet(Eleva-WebAPI):
```sh
cd Eleva-WebAPI
dotnet build
dotnet run
``` 
A aplicação estará rodando na porta 5000. Link para acessar os endpoints: `http://localhost:5000/swagger/index.html`

#### SqlLite
O banco de dados pode ser acessado pelo [DB Browser](https://sqlitebrowser.org/dl/), abrindo o arquivo Eleva.db na raiz do projeto Eleva-WebAPI. 
