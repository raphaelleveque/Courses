const express = require('express')
const app = express()
const port = 3000
const mysql = require('mysql2')

const config = {
    host: 'db',
    user: 'root',
    password: 'root',
    database: 'db'
}

const connection = mysql.createConnection(config)

connection.connect((err) => {
    if (err) {
        console.log(`Erro fatal: Não foi possível se conectar ao banco de dados. Erro: ${err}`)
        process.exit(1)
    }
    console.log('Conexão executada com sucesso!')
})

app.listen(port, () => console.log(`Server is running on port ${port}`))

app.get('/', (req, res) => {
    res.send(`
        <h1>Hello Stranger</h1>
        <h3>To inform your name, please use /yourname</h3>
        `)
})

app.get('/listar', (req, res) => {
    const query = 'SELECT * FROM PEOPLE'
    connection.query(query, (err, results) => {
        if (err) {
            console.log('Não foi possível realizar a listagem')
            return
        }
        console.log('Listagem concluída com sucesso')
        res.send(`
            <h1>Lista de nomes:</h1>
            <ul>
                ${results.map(result => `<li>${result.Names}</li>`).join('')}
            </ul>
        `)
    })
})

app.get('/admin', (req, res) => {
    if (req.headers['x-nginx-proxy']) {
        res.send('<h1>Admin Page</h1><p>This page is only accessible through Nginx.</p>');
    } else {
        res.status(403).send('Access Denied');
    }
});


app.get('/:name', (req, res) => {
    const name = req.params.name;
    const query = `INSERT INTO PEOPLE (Names) VALUES ('${name}')`
    connection.query(query, (err, result) => {
        if (err) {
            console.log('Não foi possível registrar o nome no db')
            return
        }
        console.log('Nome cadastrado com sucesso')
        res.send(`<h1>Hello ${name}!!!</h1>`)
    })
})



