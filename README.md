const express = require('express');
const app = express();
app.use(express.json());

//Rotas (endpoints da aplicação)
app.get('/home', (req,res) =>{
    res.statusCode = 200;
    res.json({msg : "Bem-vindo!"});
})

app.post('/login', (req,res) =>{
    const {usuario, senha} = req.body;

    if(usuario == 'admin' && senha == '1234')
    {
        res.statusCode = 202;
        res.json({msg: "Autenticado com sucesso!", user : usuario, senha: senha});
    } else {
        res.statusCode = 201;
        res.json({msg: "Usuário não autorizado"});
    }
});

app.listen(3000);
console.log('Servidor rodando na porta 3000');
