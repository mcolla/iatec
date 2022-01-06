# IATec
Desafio técnico para oportunidade no IATec


# Estrutura das pastas
Eu seguimentei em 2 pastas os fontes, backend e frontend.

Bom eu iniciei na parte backend, não tendo tanto conhecimento prévio em C#, fui atrás de aprender, não tive muito êxito na primeira versão (pasta backend\backend-IATec), mas de qualquer forma me ajudou no aprendizado, então pra tentar não perder muito tempo, criei uma versão 2 (backend\iatec-v2), conforme print:

<img src="https://live.staticflickr.com/65535/51797650837_331327aac8_b.jpg" alt="Swagger da API">

## 💻 Pré-requisitos API

Ambiente utilizado:
* Docker `<ubuntu + mysql:8>`
* ASP.NET Core 5.0 
* EF Core 5.0
* Abordagem Code First `<acessando o MySQL>`
* Biblioteca Pomelo.EntityFrameworkCore.MySQL `<versão 5.0.0-alpha.2>`

## 🚀 Criando o backend

Inicialmente comecei com um uma entidade mais simples, relacionada ao solicitado, no caso <Products>, simulando produtos para serem usados nos veículos, e na sequencia a entidade de veículos <Vehicles>:
- [x] Criado as entidades <Products> e <Vehicles>
- [x] Criado o contexto AppDbConnect (mapeamento e configurações)
- [x] Definido a alimentação das tabelas Products e Vehicles (HasData)
- [x] Definido string de conexão ao MySQL (appsettings.json) 
- [x] Configurar serviço no arquivo Startup (provedor, conexão)
- [x] Criado os controllers 
  
## ☕ Usando o backend
Para usar o backend, basta:

Acessar pasta do Docker (\iatec-v2\Docker) e subir o container com o MySQL
```
docker run
```
- No Visual Studio, acessar o Package Manager Console, para rodar as migrations, criando toda a estrutura no MySQL, executar:
```
PM> update-database
```
Na sequência ainda no Visual Studio, F5, para iniciar a API, e debugar a mesma utilizando o Swagger.
Exemplos:
- Buscando todos os veículos e produtos (populados na migration), basta clicar em < Try it out > e depois em < Execute >
  
<img src="https://live.staticflickr.com/65535/51799018834_71b93b1959_b.jpg" alt="Debugando a API">
  
<br><br><br><br>
## 💻 Pré-requisitos frontend

Ambiente utilizado:
* Angular, Angular CLI 13.1
* Bootstrap 4 
* Node 17.3
  
## ☕ Usando o frontend
Para usar o frontend, basta acessar pasta do projeto (frontend\iatecv2) e executar:
```
ng serve
```
  
Observação: como no backend, iniciei o projeto (frontend\iatec), mas tive vários erros, gastei tempo pesquisando tentando resolver, exemplo, ao adicionar o Bootstrap ao projeto:
```
C:\Sandbox\iatec\frontend\iatec (main -> origin)
λ npm install @ng-bootstrap/ng-bootstrap
TypeError: Class extends value undefined is not a constructor or null
    at Object.<anonymous> (C:\Users\micha\AppData\Roaming\nvm\v12.16.1\node_modules\npm\node_modules\socks-proxy-agent\dist\agent.js:114:44)
    at Module._compile (node:internal/modules/cjs/loader:1097:14)
    at Object.Module._extensions..js (node:internal/modules/cjs/loader:1149:10)
    at Module.load (node:internal/modules/cjs/loader:975:32)
    at Function.Module._load (node:internal/modules/cjs/loader:822:12)
    at Module.require (node:internal/modules/cjs/loader:999:19)
    at require (node:internal/modules/cjs/helpers:102:18)
    at Object.<anonymous> (C:\Users\micha\AppData\Roaming\nvm\v12.16.1\node_modules\npm\node_modules\socks-proxy-agent\dist\index.js:5:33)
    at Module._compile (node:internal/modules/cjs/loader:1097:14)
    at Object.Module._extensions..js (node:internal/modules/cjs/loader:1149:10)
    at Module.load (node:internal/modules/cjs/loader:975:32)
    at Function.Module._load (node:internal/modules/cjs/loader:822:12)
    at Module.require (node:internal/modules/cjs/loader:999:19)
    at require (node:internal/modules/cjs/helpers:102:18)
    at Object.<anonymous> (C:\Users\micha\AppData\Roaming\nvm\v12.16.1\node_modules\npm\node_modules\make-fetch-happen\lib\agent.js:161:25)
    at Module._compile (node:internal/modules/cjs/loader:1097:14)
  ```
  

Então, resolvi abandonar e iniciar outro projeto (frontend\iatecv2), mas ai não consegui finalizar devido ao tempo, só consegui adiantar parte da entidade Product, faltou de Vehicle e conectar a API para consumir e enviar dados.

A estrutura definida:
- [x] importação dos módulos
- [x] criação das rotas
- [x] Adicionando Bootstrap ao projeto usando CDN
- [x] Criando services
  [] Conectando API
  
 
 <br><br><br><br>
[⬆ Voltar ao topo](#IATec)<br>
