# API de cadastros e gestão de estoque

Este é um projeto em C#, consiste em uma API de cadastro e gestão de estoque. A API utiliza o framework ASP.NET Core e banco de dados Microsoft SQL Serve.

A API possui um endpoit para autenticação do usuário (login), que recebe os dados de usuário e verifica sua existência no banco de dados, se consistente as informações, realiza a geração de um token de acesso com tempo de expiação na qual será usado para acessar dos demais endpoints da API

Este projeto possui endpoints para manipulação de Clientes/Lojas, permitindo listar todas a lojas, listagem por nome, cadastrar, listar por ID, atualizar os dados das lojas existentes e deletar.

Também possui endpoints para realizar as operações de CRUD dos "tipos de Leve me": operações estás de listagem de todos os tipos de "leve me", cadastro, listagem  de leve me por cliente, listagem por ID, listagem por nome, atualizar e deletar os tipos existente.

Possui CRUD de produtos também que permite: A listagem de todos os produtos, a listagem por nome, o cadastro de um novo produto, a listagem por lojas, a listagem por ID, atualização e remoção do mesmo, e um controle de vendas do produto.

# Demonstração
