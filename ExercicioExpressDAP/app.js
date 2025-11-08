const express = require('express');
const path = require('path');
const fs = require('fs');
const app = express();
app.use(express.json());

let usuariosAutenticados = [];

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
        usuariosAutenticados.push({
            usuario: usuario,
            dataLogin: dataAtual,
            horaLogin: horaAtual
        });
        
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
    const {usuario} = req.body;
    
    // Verifica se o usuário está autenticado
    const usuarioAutenticado = usuariosAutenticados.find(u => u.usuario === usuario);
    
    if(usuarioAutenticado){
        res.statusCode = 200;
        res.json({
            msg: "Informações do usuário autenticado:",
            usuario: usuarioAutenticado.usuario,
            dataLogin: usuarioAutenticado.dataLogin,
            horaLogin: usuarioAutenticado.horaLogin
        });
    } else {
        res.statusCode = 401;
        res.json({
            msg: "Usuário não está autenticado. Faça login primeiro."
        });
    }
});

app.listen(3000);
console.log('Servidor rodando na porta 3000');