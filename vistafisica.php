<html>
    <head>
        <title></title>
    <head>
    <body>
    <form method="post" action="">
    <a href="https://ibb.co/9GyLLd2"><img src="https://i.ibb.co/t3Ytt1c/trabajofisica.jpg" alt="trabajofisica"></a>
    <label>Ingrese numero 1:</label>
    <input type="text" name="numero1"><br>
    <label>Ingrese numero 2:</label>
    <input type="text" name="numero2"><br>
    <input type="submit" name="sumar"><br>

    </body>

    <?php
    $numero1 = $_POST['numero1'];
    $numero2 = $_POST['numero2'];

    $suma = $numero1 + $numero2;

    echo "la suma es : " + $suma;
    ?>
</html>