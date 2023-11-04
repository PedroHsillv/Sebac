<?php
    include("conectadb2.php"); // Certifique-se de que o arquivo esteja correto e tenha a extensão .php

    // Verifica a conexão com o banco de dados
    if ($conn->connect_error) {
        die("Erro na conexão com o banco de dados: " . $conn->connect_error);
    }

    // Insere um novo registro de acesso no banco de dados
    $stmt = $conn->prepare("INSERT INTO acessos (data_acesso) VALUES (NOW())");
    $stmt->execute();

    // Obtém o número total de acessos do banco de dados
    $result = $conn->query("SELECT COUNT(id) as total FROM acessos");
    $row = $result->fetch_assoc();
    $totalAcessos = $row["total"];


?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="assets/img/Sebac2.png" type="image/png">
    <title>Contador de Acessos</title>
    <link rel="stylesheet" href="assets/css/contador.css">
</head>
<body>
    <div class="container">
        <h1>Seja Bem-vindo!</h1>
        <p>
            "Esta página foi criada com o intuito de saber quantos querem 
            descobrir a identidade secreta do SEXTO MEMBRO, uma figura enigmática que intrigou a 
            todos com suas ações misteriosas. Se você está ansioso para desvendar esse mistério e 
            fazer parte desse intrigante enigma, continue compartilhando a pagina e então ele revelara sua identidade. 
            Estamos prestes a revelar segredos que irão surpreendê-lo e mudar sua percepção para sempre. 
            Prepare-se para desvendar os segredos mais profundos e obscuras verdades. Junte-se a nós nesta 
            busca pela verdade e desvende o enigma do SEXTO MEMBRO."</p>
        <?php
        echo "<h1>$totalAcessos pessoas acessaram esta página!</h1>";
        ?>
    </div>
</body>
</html>

