const url = 'http://files.cod3r.com.br/curso-js/funcionarios.json'
const axios = require('axios')

const data = []
axios.get(url).then(response => {
    console.log(response.data.filter(pessoa => pessoa.pais === 'China').filter(pessoa => pessoa.genero === 'F').reduce((funcionario, funcAtual) => {
        if (funcAtual.salario < funcionario.salario)
            return funcAtual
        return funcionario
    }))
})

//console.log(data.filter(pessoa => pessoa.pais === 'China'))