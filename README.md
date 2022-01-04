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
  
  
<br><br>
[⬆ Voltar ao topo](#IATec)<br>
