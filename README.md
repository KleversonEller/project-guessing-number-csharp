# **Contexto do projeto**

Criando jogo Guessing Number (Adivinha o numero), esse projeto foi proposto para validar meus aprendizados em C# relacionados a minha 2ª semana de estudos.
<br/>
O projeto conta com a lógica do jogo e testes unitários que valida essa lógica.
<br/>
(Obs: esse projeto não conta com um executável).

## **Stacks utilizadas no projeto**

Foi utilizado o .NET Core na versão 6.0
<br/>
A biblioteca de testes xUnit e a Fluent Assertions
<br/>
E a biblioteca Moq para os mocks da aplicação.

## **Como iniciar o projeto localmente**

Caso queira iniciar o projeto localmente devera ter instalado o .NET 6.0 e seguir os seguintes passos:
<br/>
Primeiro clone o projeto:
<br/>

```sh
git clone git@github.com:KleversonEller/project-guessing-number-csharp.git
```
<br/>

Em seguida entre na pasta do projeto e utilize o seguinte comando para instalar as dependências do projeto:
<br/>

```sh
cd project-guessing-number-csharp/src
dotnet restore
```
<br/>

Caso queira executar os testes basta utilizar:
<br/>

```sh
cd project-guessing-number-csharp/src
dotnet test
```
