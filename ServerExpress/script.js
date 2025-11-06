const express = require('express');
const app = express();
app.use(express.json());
app.use(express.urlencoded({ extended: true })); // Para processar dados de formulário

app.get('/home', (req, res) => res.send('Home Page'));

// Rota GET para mostrar formulário de login
app.get('/login', (req, res) => {
    res.send(`
        <html>
            <body>
                <h1>Login</h1>
                <form action="/login" method="POST">
                    <input type="text" name="usuario" placeholder="Usuário" required><br><br>
                    <input type="password" name="senha" placeholder="Senha" required><br><br>
                    <button type="submit">Login</button>
                </form>
            </body>
        </html>
    `);
});

// Rota POST para processar login
app.post('/login', (req, res) => res.json({ message: 'Login recebido', user: req.body }));

app.listen(3000, () => console.log('Servidor rodando na porta 3000'));