# Nginx Node Application

Esta é uma aplicação Node.js com Nginx como proxy reverso e MySQL como banco de dados.

## Como executar

### Usando Docker Hub

A maneira mais simples de executar a aplicação é usando a imagem pré-construída do Docker Hub:

```bash
# Baixar a imagem
docker pull raphaellev/nginx-node:latest

# Executar o container
docker run -p 3000:3000 raphaellev/nginx-node:latest
```

### Usando Docker Compose (desenvolvimento local)

Se você quiser executar o ambiente completo com Nginx e MySQL:

1. Clone este repositório
2. Execute:
```bash
docker compose up
```

## Portas

- Aplicação Node.js: 3000
- Nginx: 80
- MySQL: 3306

## Estrutura do Projeto

- `/app` - Código fonte da aplicação Node.js
- `/nginx` - Configurações do Nginx
- `/mysql` - Scripts de inicialização do MySQL

## Tecnologias Utilizadas

- Node.js
- Express
- Nginx
- MySQL
- Docker 