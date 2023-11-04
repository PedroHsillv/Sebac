<?php
// Inicia a sessão (se já não estiver iniciada)
session_start();

// Destroi a sessão
session_destroy();

// Redireciona para a página de login ou para qualquer outra página desejada após o logout
header("Location: login.php");
exit();
?>

