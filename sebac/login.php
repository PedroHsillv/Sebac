<?php
include("conectadb3.php");

session_start(); // Inicia a sessão

if ($conn->connect_error) {
    die("Falha na conexão: " . $conn->connect_error);
}

// Recebe os dados do formulário
if ($_SERVER["REQUEST_METHOD"] == "POST"){
    $login = $_POST['login']; // Pode ser tanto email quanto nome de usuário
    $senha = md5($_POST['senha']); // Utilizando md5 para criptografar a senha

    // Verifica se o email ou nome de usuário e senha correspondem a um usuário cadastrado
    $sql = "SELECT * FROM usuarios WHERE (usu_email = '$login' OR usu_nome_usuario = '$login') AND usu_senha = '$senha'";
    $result = $conn->query($sql);

    // Verifica se o usuário está autenticado
    if(isset($_SESSION['usuario'])){
    // Usuário está autenticado, redireciona para a página de destino
    header("Location: index.html");
    exit();

    } else {
        // Credenciais inválidas, exibe mensagem de erro
        echo "<script>window.alert('Email ou nome de usuário, ou senha incorretos. Por favor, tente novamente.');</script>";
    }

    if ($result->num_rows > 0) {
        // Login bem-sucedido, armazena o nome de usuário na sessão e redireciona para a página de destino
        $_SESSION['usuario'] = $login;
        header("Location: index.html");
        exit();

    } else {
        // Credenciais inválidas, exibe mensagem de erro
        echo "<script>window.alert('Email ou nome de usuário, ou senha incorretos. Por favor, tente novamente.');</script>";
    }
}
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" href="assets/img/Sebac2.png" type="image/png">
    <link rel="stylesheet" href="assets/css/login.css">
    <title>Login</title>
</head>

<body>
    
    <h2>Login</h2>
    <form action="login.php" method="POST">
        <label for="login">Email ou Nome de Usuário:</label>
        <input type="text" name="login" required><br>

        <label for="senha">Senha:</label>
        <input type="password" name="senha" required><br>

        <input type="submit" value="Entrar">
    </form>
</body>

</html>
