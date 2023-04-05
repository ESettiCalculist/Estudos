//variaveis da bolinha
let xBolinha = 300;
let yBolinha = 200;
let diametro = 12;
let raio = diametro / 2;

//velocidade da bolinha
let velXBolinha = 6;
let velYBolinha = 6;


// variaveis da raquete
let xRaquete = 5;
let yRaquete = 150;
let raqueteComprimento = 7
let raqueteAltura = 60
let colidiu = false

// variaveis do oponente
let xRaqueteOponente = 585;
let yRaqueteOponente = 150;
let velocidadeYOponente;

// placar do jogo
let meusPontos = 0;
let pontosDoOponente = 0;

// sons do jogo
let raquetada;
let ponto;
let trilha;

function preload(){
  trilha = loadSound("trilha.mp3");
  ponto = loadSound("ponto.mp3");
  raquetada = loadSound("raquetada.mp3");
}

function setup() {
  createCanvas(600, 400);
  trilha.loop();
}

function draw() {
  background(0);
  mostrarABolinha();
  movimentacaoBolinha();
  colisaoBordas();
  mostrarRaquete(xRaquete, yRaquete);
  mostrarRaquete(xRaqueteOponente, yRaqueteOponente)
  movimentaRaquete();
  //colisaoRaquete();
  colisaoRaqueteBiblioteca(xRaquete, yRaquete);
  colisaoRaqueteBiblioteca(xRaqueteOponente, yRaqueteOponente);
  movimentaRaqueteOponente();
  placarDoJogo();
  marcaPonto();
  bolinhaNaoFicaPresa();
  

}
function movimentacaoBolinha(){
    xBolinha +=  velXBolinha;
  yBolinha += velYBolinha;
}
function mostrarABolinha(){
  circle(xBolinha,yBolinha,diametro)
}
function colisaoBordas(){
  if (xBolinha + raio> width || xBolinha - raio < 0){
      velXBolinha *= -1;
    }
  if (yBolinha + raio> height || yBolinha - raio < 0 ){
      velYBolinha *= -1;
      }
}
function mostrarRaquete(x, y){
  rect(x, y, raqueteComprimento, raqueteAltura)
}
function movimentaRaquete() {
  if (keyIsDown(UP_ARROW)){
     yRaquete -= 10;
  }
  if (keyIsDown(DOWN_ARROW)){
    yRaquete += 10;
  }
}
function movimentaRaqueteOponente() {
  if (keyIsDown(87)){
     yRaqueteOponente -= 10;
  }
  if (keyIsDown(83)){
    yRaqueteOponente += 10;
  }
}
function colisaoRaqueteBiblioteca(x, y){
  colidiu = 
  collideRectCircle(x, y, raqueteComprimento, raqueteAltura, xBolinha, yBolinha, raio);
  if (colidiu){
    velXBolinha *= -1;
    raquetada.play();
  }
}
function placarDoJogo(){
  stroke(255);
  textAlign(CENTER);
  textSize(16);
  fill(color(255,140,0));
  rect(150,10 ,40, 20);
  fill(255);
  text (meusPontos, 170,  26);
  fill(color(255,140,0));
  rect(450,10 ,40, 20);
  fill(255);
  text (pontosDoOponente, 470,  26);
}
function marcaPonto(){
  if (xBolinha > 595){
    meusPontos += 1;
    ponto.play();
  }
  if (xBolinha < 5){
    pontosDoOponente += 1;
    ponto.play();
  }
}