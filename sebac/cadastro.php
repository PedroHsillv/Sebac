<?php
include("conectadb3.php");

if ($conn->connect_error) {
    die("Falha na conexão: " . $conn->connect_error);
}

// Recebe os dados do formulário
if ($_SERVER["REQUEST_METHOD"] == "POST"){
    $email = $_POST['email'];
    $senha = md5($_POST['senha']); // Utilizando md5 para criptografar a senha
    $nomeUsuario = md5($_POST['nome_usuario']); // Utilizando md5 para criptografar o nome de usuário

// Verifica se o email ou nome de usuário já estão cadastrados
$sql = "SELECT * FROM usuarios WHERE usu_email = '$email' OR usu_nome_usuario = '$nomeUsuario'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // Email ou nome de usuário já cadastrados, exibe mensagem de erro
    echo "<script>window.alert('Email ou Nome de Usuário já cadastrados. Por favor, escolha outro.');</script>";
} else {
    // Email e nome de usuário não estão cadastrados, realiza o cadastro
    $sql = "INSERT INTO usuarios (usu_email, usu_senha, usu_nome_usuario, usu_status) 
    VALUES ('$email', '$senha', '$nomeUsuario', 'S')";
    
    if ($conn->query($sql) === TRUE) {
        echo "<script>window.alert('Usuário cadastrado com sucesso!'); window.location.href='index.html';</script>";
    } else {
        echo "Erro ao cadastrar o usuário: " . $conn->error;
    }
}
}

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="assets/img/Sebac2.png" type="image/png">
    <link rel="stylesheet" href="assets/css/cadastro.css">
    <title>Cadastro de Usuário</title>
</head>

<body>
    <h2>Cadastro de Usuário</h2>
    <form action="cadastro.php" method="POST">
        <label for="email">Email:</label>
        <input type="email" name="email" required><br>

        <label for="senha">Senha:</label>
        <input type="password" name="senha" required><br>

        <label for="nome_usuario">Nome de Usuário:</label>
        <input type="text" name="nome_usuario" required><br>

        <input type="submit" value="Cadastrar">
    </form>
</body>

</html>