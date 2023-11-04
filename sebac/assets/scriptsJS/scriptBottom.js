// Seleciona todos os botões com a classe "read_button"
var buttons = document.querySelectorAll('.ler_botao');

// Itera pelos botões e adiciona um event listener a cada um
buttons.forEach(function(button) {
    button.addEventListener('click', function() {
        // Encontra o card pai do botão clicado
        var card = button.closest('.card');
        card.classList.toggle('active');

        if (card.classList.contains('active')) {
            button.textContent = 'Ler Menos';
        } else {
            button.textContent = 'Ler Mais';
        }
    });
});
