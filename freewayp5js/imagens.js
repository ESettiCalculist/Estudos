//preloads
let imgEstrada;
let imgCarro1;
let imgCarro2;
let imgCarro3;
let imgPersona;

//sons do jogo
let somDaColisao;
let somDoPonto;
let somDaTrilha;

function preload(){
  imgEstrada = loadImage("imagens/estrada.png");
  imgPersona = loadImage("imagens/ator-1.png");
  imgCarro1 = loadImage("imagens/carro-1.png");
  imgCarro2 = loadImage("imagens/carro-2.png");
  imgCarro3 = loadImage("imagens/carro-3.png");
  imgCarros = [imgCarro1, imgCarro2, imgCarro3, imgCarro1, imgCarro2, imgCarro3];
  
  somDaTrilha = loadSound("sons/trilha.mp3");
  somDoPonto = loadSound("sons/pontos.wav");
  somDaColisao = loadSound("sons/colidiu.mp3");
}



