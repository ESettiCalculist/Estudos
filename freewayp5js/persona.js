//persona
let yPersona = 370;
let xPersona = 100;
let colisao = false;
let meusPontos = 0;

function mostraPersona(){
  image(imgPersona, xPersona, yPersona, 50, 30);
}

function movimentaPersona(){
  if (keyIsDown(UP_ARROW)){
     yPersona -= 3;
  }
  if (keyIsDown(DOWN_ARROW)){
    if(podeSeMover()){
      yPersona += 3;
    } 
  }
  if (keyIsDown(RIGHT_ARROW)){
    xPersona += 3;
  }
  if (keyIsDown(LEFT_ARROW)){
    xPersona -= 3;
  }
}
function verificaColisao(){
  //collideRectCircle(x1, y1, width1, height1, cx, cy, diameter)
    for (let i = 0; i < imgCarros.length; i ++){
      colisao = collideRectCircle(xCarros[i], yCarros[i], 45, 25, xPersona, yPersona, 10)
      if (colisao){
        colidiu();
        if (meusPontos>0)
          meusPontos -= 1;
      }
      }
    }
function colidiu(){
  yPersona = 370;
  somDaColisao.play();
}
function placarPontos(){
  textSize(16);
  fill(color(255,140,0));
  rect(10,10 ,40, 20);
  fill(0)
  text(meusPontos, 25, 25)
}
function marcaPontos(){
  if (yPersona < 15){
    meusPontos += 1;
    yPersona = 370;
    somDoPonto.play();
  }
}
function podeSeMover(){
  return yPersona < 370;
}