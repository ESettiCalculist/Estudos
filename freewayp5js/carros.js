//codigo dos carros
let yCarros = [40, 100, 150, 210, 270, 318];
let xCarros = [600, 400, 700, 500, 600, 600];
let velocidadeCarros = [2, 3, 5, 3.2, 2.5, 1.7];
let comprimentoCarro = 50;
let alturaCarro = 40;

function mostraCarro(){
  for(let i = 0; i < imgCarros.length; i++){
  image(imgCarros[i], xCarros[i], yCarros[i], comprimentoCarro, alturaCarro);
  }
}
function movimentaCarro(){
  for (let i = 0; i < imgCarros.length; i++)
  xCarros[i] -= velocidadeCarros[i];
}
function retornoCarros(){
  for(let i = 0; i < imgCarros.length; i ++)
  if (passouTela(xCarros[i])){
    xCarros[i] = 600;
  }
}

function passouTela(xCarros){
  return xCarros < -50;
}