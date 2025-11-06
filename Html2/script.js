var canvas = document.querySelector('canvas');
canvas.height = window.innerHeight;
canvas.width = window.innerWidth;

var c = canvas.getContext('2d');
/*var mousex = 0;
var mousey = 0;

var x =240; y = 240;
canvas.addEventListener('mousemove', function(event){
    const rect = canvas.getBoundingClientRect();
    mousex = event.clientX - rect.left;
    mousey = event.clientY - rect.top;
});
function particulo(){
    requestAnimationFrame(particulo);
    c.clearRect(0, 0, window.innerWidth, window.innerHeight);
    x += (mousex - x) * 0.1;
    y += (mousey - y) * 0.1;
    c.beginPath();
    
    c.arc(x, y, 50, 0, Math.PI * 2);
    c.fillStyle = 'red';
    c.fill();
}
particulo();*/
/*var teclas={};
var x=100;
var y=100;
var velocidade = 10;
var toque = 1;
var xa = Math.abs((Math.random() * window.innerWidth)-100);
var ya = Math.abs((Math.random() * window.innerHeight)-100);
document.addEventListener('keydown', (event) => {
    teclas[event.key]= true;
});
document.addEventListener('keyup', (event) => {
    teclas[event.key]= false;
});

function animation(){
    requestAnimationFrame(animation);

    c.clearRect(0, 0, window.innerWidth, window.innerHeight);
    c.fillStyle = 'rgba(0, 0, 191)';
    if(toque==1){
        xa = (Math.random() * window.innerWidth);
        ya = (Math.random() * window.innerHeight);

        c.fillRect(xa, ya, 100, 100);
        toque = 0;
    }
    else{

        c.fillRect(xa, ya, 100, 100);
    }   
    c.fillStyle = 'rgba(0, 255, 191)';
    if(teclas['w']) y -= velocidade;
    if(teclas['s']) y += velocidade;
    if(teclas['a']) x -= velocidade;
    if(teclas['d']) x += velocidade;
    if(x < 0) x = 0;
    if(x > window.innerWidth - 100) x = window.innerWidth - 100;
    if(y < 0) y = 0;
    if(y > window.innerHeight - 100) y = window.innerHeight - 100;
    if(x >= xa - 100 && x <= xa + 100 && y >= ya - 100 && y <= ya + 100){
        toque = 1;
    }

    c.fillRect(x, y, 100, 100);
}
animation();*/
/*for(var i = 0; i < 10; i++){
    var x = Math.random() * window.innerWidth;
    var y = Math.random() * window.innerHeight;
    var r = Math.floor(Math.random() * 256);
    var g = Math.floor(Math.random() * 256);
    var b = Math.floor(Math.random() * 256);
    c.fillStyle = `rgb(${r}, ${g}, ${b})`;
    c.fillRect(x, y, 100, 100);
}

for(var i = 0; i < 10; i++){
    var x = Math.random() * window.innerWidth;
    var y = Math.random() * window.innerHeight;
    var r = Math.floor(Math.random() * 256);
    var g = Math.floor(Math.random() * 256);
    var b = Math.floor(Math.random() * 256);
    c.beginPath();
    c.moveTo(x, y);
    x = Math.random() * window.innerWidth;
    y = Math.random() * window.innerHeight;
    c.lineTo(x, y);
    c.strokeStyle = `rgba(${r}, ${g}, ${b}, 0.8)`;
    c.lineWidth = 3;
    c.stroke();
}

for(var i = 0; i < 30; i++){
    var x = Math.random() * window.innerWidth;
    var y = Math.random() * window.innerHeight;
    var z = Math.random() * 100;
    var r = Math.floor(Math.random() * 256);
    var g = Math.floor(Math.random() * 256);
    var b = Math.floor(Math.random() * 256);
    c.beginPath();
    c.arc(x, y, z, 0, Math.PI * 2, false);
    c.fillStyle = `rgba(${r}, ${g}, ${b}, 0.5)`;
    c.strokeStyle = `rgb(${r}, ${g}, ${b})`;
    c.fill();
    c.stroke(); 
}*/

