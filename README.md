# API de cadastros e gestão de estoque

Este é um projeto em C#, consiste em uma API de cadastro e gestão de estoque. A API utiliza o framework ASP.NET Core e banco de dados Microsoft SQL Serve.

A API possui um endpoit para autenticação do usuário (login), que recebe os dados de usuário e verifica sua existência no banco de dados, se consistente as informações, realiza a geração de um token de acesso com tempo de expiação na qual será usado para acessar dos demais endpoints da API

Este projeto possui endpoints para manipulação de Clientes/Lojas, permitindo listar todas a lojas, listagem por nome, cadastrar, listar por ID, atualizar os dados das lojas existentes e deletar.

Também possui endpoints para realizar as operações de CRUD dos "tipos de Leve me": operações estás de listagem de todos "leve mes" cadastrado, cadastro, listagem por cliente, listagem por ID, listagem por nome, atualizar e deletar os tipos existente.

Possui CRUD de produtos também que permite: A listagem de todos os produtos, a listagem por nome, o cadastro de um novo produto, a listagem por lojas, a listagem por ID, atualização e remoção do mesmo, e um controle de vendas do produto.

# Demonstração
Endpoints

# Como executar o projeto

Para executar o projeto, siga as seguintes etapas:
1. Clone este repositório em sua máquina local usando o comando git clone ```https://github.com/jonatassouta/LeveMeApi.git```
2. Abra o projeto no Visual Studio ou em outra IDE de sua preferência.
3. Configure a string de conexão do banco de dados no arquivo ```appsettings.json``` dentro da pasta ```LeveMvAPi```.
4. No Console do Gerenciador de Pacotes, execute o comando ```Update-Database``` para criar o banco de dados e suas tabelas.
5. Compile o projeto e execute a aplicação.
6. Use o Swagger ou outra ferramenta similar para testar os endpoints da API.
