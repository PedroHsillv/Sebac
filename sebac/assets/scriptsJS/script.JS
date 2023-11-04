const botaoTexto = document.getElementById('meuBotao');
const texto = document.getElementById('loreText');



botaoTexto.addEventListener('click', function(){
    if(botaoTexto.textContent == 'Esconder'){
        botaoTexto.textContent = 'Mostrar Mais';
        texto.textContent = 'Há muito tempo, no mundo de Sebac, a paz e a prosperidade reinavam...';
    }
    else{
        botaoTexto.textContent = 'Esconder';
        texto.textContent = 'Há muito tempo, no mundo de Sebac, a paz e a prosperidade reinavam. As terras eram habitadas por criaturas mágicas e seres humanos que viviam em harmonia. Mas como em todo lugar, havia aqueles que cobiçavam o poder acima de tudo, e eles eram conhecidos como os Vilões da Sombra.Os Vilões da Sombra eram uma sociedade secreta, uma rede de criminosos e mestres da manipulação que operavam nas sombras, longe dos olhos das autoridades e dos heróis que protegiam Sebac. Eles eram liderados por um sinistro feiticeiro chamado Hugo, cujos olhos brilhavam com um fogo maligno que podia enfeitiçar até mesmo os mais fortes.A sociedade secreta estava empenhada em alcançar um objetivo obscuro: conquistar os poderes mágicos que mantinham Sebac em equilíbrio. Eles acreditavam que, com esses poderes em suas mãos, poderiam controlar todo o mundo e subjugar todos os seres vivos.Os Vilões da Sombra eram formidáveis em número e em astúcia. Eles espalharam mentiras e enganos, semeando a discórdia entre os reinos e manipulando governantes para seus próprios fins. Usaram suas habilidades mágicas para criar criaturas monstruosas e causar desastres naturais, lançando Sebac em caos.Mas nem tudo estava perdido. Em meio ao caos, surgiram heróis corajosos e destemidos, cada um com seu próprio conjunto de habilidades e uma vontade inabalável de deter os Vilões da Sombra. Juntos, eles formaram uma aliança improvável, jurando proteger Sebac e derrotar a sociedade secreta.A batalha entre os heróis e os Vilões da Sombra foi épica, com confrontos mágicos e estratégias elaboradas em ambos os lados. No final, a determinação e a bondade prevaleceram sobre a escuridão, e os Vilões da Sombra foram derrotados. Hugo, o sinistro feiticeiro, foi selado em um reino distante, onde suas maquinações malignas não mais alcançariam Sebac.Com os Vilões da Sombra derrotados, a paz retornou a Sebac, e os heróis que se levantaram para enfrentar a ameaça tornaram-se lendas, inspirando gerações futuras a lutar pela justiça e proteger seu amado mundo da escuridão.No entanto, as sombras nunca desaparecem completamente, e Sebac sempre precisará de heróis dispostos a enfrentar o mal.';
    }
});