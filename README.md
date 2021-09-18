Library
---

Após realizar a clonagem do repositorio, verifique se na máquina em que irá testar
Para rodar a aplicação tem o SDK do .NET. Para verificar insira o código abaixo.

```c#
 dotnet --version
```
Se aparecer o resultado abaixo

```
5.0.400
```

Isso quer dizer que tem o SDK do .Net instalado e assim poderá prosseguir com os testes

Utilize o programa que desejar, Visual Studio, Visual Studio Code, Rider etc.

Ao abrir o projeto, abra o terminal integrado do aplicativo e insira o código abaixo:
```c#
dotnet watch run
```
A API irá ativar e poderá realizar os devidos testes pelo Postman ou Insomnia.

No repositório consta uma pasta com nome **RequisitionCollections** nela consta coleções para testes de requisições,
basta importar na aplicação que se sinta mais confortável.