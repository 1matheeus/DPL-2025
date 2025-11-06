const express = require('express');
const path = require('path');
const fs = require('fs');
const app = express();
app.use(express.json());

//Rotas (endpoints da aplicação)
app.get('/home', (req,res) =>{
    res.statusCode = 200;
    res.json({msg : "Bem-vindo!"});
})

app.post('/login', (req,res) =>{
    const {usuario, senha} = req.body;
    const dataPath = path.join(__dirname, 'data', 'users.json');
    const fileData = fs.readFileSync(dataPath, 'utf-8');
    const users = JSON.parse(fileData);

    const user = users.find(u => u.usuario === usuario && u.senha === senha);

    const dataHoraLogin = new Date();
    const dataAtual = dataHoraLogin.toLocaleDateString('pt-BR');
    const horaAtual = dataHoraLogin.toLocaleTimeString('pt-BR');

    if(user){
        res.statusCode = 202;
        res.json({
            msg: "Autenticado com sucesso! Bem-vindo," + usuario + "!",
        });
    } else {
        res.statusCode = 201;
        res.json({
            msg: "Usuário não autorizado",
        });
    }
});

app.post('/data', (req,res) =>{
    const {info} = req.body;
    res.statusCode = 200;
    let meuVetor = [];
    
    if (meuVetor.includes())
    res.json({msg : "Dados recebidos com sucesso!", data: info});
}

app.listen(3000);
console.log('Servidor rodando na porta 3000');