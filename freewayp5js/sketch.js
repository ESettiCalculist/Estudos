function setup() {
 createCanvas(500, 400);
  somDaTrilha.loop();
}

function draw() {
  background(imgEstrada);
  mostraCarro();
  movimentaCarro();
  mostraPersona();
  movimentaPersona();
  retornoCarros();
  verificaColisao();
  placarPontos();
  marcaPontos();
}



