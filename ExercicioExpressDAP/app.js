const express = require('express');
const path = require('path');    // ← ADICIONAR ESTE
const fs = require('fs');        // ← ADICIONAR ESTE
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

    if(user){
        res.send(`<h3>Loginrealizadocomsucesso! Bem-vindo,${usuario}.</h3>`);
        res.statusCode = 202;
        res.json({msg: "Autenticado com sucesso!", usuario : usuario, senha: senha});
    } else {
        res.send(`<h3>Usuário ou senhainválidos. <a href="/">Tentenovamente</a></h3>`);
        res.statusCode = 201;
        res.json({msg: "Usuário não autorizado"});
    }
});

app.listen(3000);
console.log('Servidor rodando na porta 3000');