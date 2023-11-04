// Texto que será exibido
var texto = document.getElementById("text2").textContent;

// Elemento HTML onde o texto será exibido
var elemento = document.getElementById("texto-animado2");

// Adicione uma classe CSS ao elemento
elemento.classList.add("texto-estilizado2");

// Índice para rastrear qual parte do texto deve ser exibida
var indice = 0;

// Função para exibir o texto letra por letra
function exibirTexto() {
  // Verifica se o índice é menor que o comprimento do texto
  if (indice < texto.length) {
    // Adiciona a próxima letra ao elemento HTML
    elemento.innerHTML += texto.charAt(indice);
    // Incrementa o índice para obter a próxima letra na próxima chamada da função
    indice++;
    // Chama a função novamente após um intervalo de tempo (velocidade de digitação)
    setTimeout(exibirTexto, 50); // 50 milissegundos (ajuste conforme desejado)
  }
}

// Chama a função para iniciar o efeito de digitação quando a página carrega
window.onload = exibirTexto;