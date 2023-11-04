// Verifica se já existe um valor no localStorage para o contador de acessos
if(localStorage.getItem('acessos')) {
    // Se existir, obtém o valor atual do localStorage
    var acessos = parseInt(localStorage.getItem('acessos'));
} else {
    // Se não existir, define o valor inicial como 0
    var acessos = 0;
}

// Incrementa o contador de acessos
acessos++;

// Atualiza o valor no localStorage
localStorage.setItem('acessos', acessos);

// Atualiza o conteúdo da página com o número de acessos
document.getElementById('contador').textContent = acessos;
