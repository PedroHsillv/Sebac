<?php 
    // Configurações do banco de dados
    $servidor = "localhost";
    
    $banco = "cadastro";
    
    $usuario = "root";
    
    $senha = "";

    // Cria uma conexão com o banco de dados MySQL
    $conn = mysqli_connect($servidor, $usuario, $senha,$banco);
?>