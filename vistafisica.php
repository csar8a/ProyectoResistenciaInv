<html>
    <head>
        <title></title>
    <head>
    <body>
    <form method="post" action="">
    <div>
    <h1 style="color:green">SISTEMA DE CALCULO DEL PROBLEMA:</h1>
    <a href="https://ibb.co/9GyLLd2"><img src="https://i.ibb.co/t3Ytt1c/trabajofisica.jpg" alt="trabajofisica"></a>
    </div>
   
    <label>Distancia 1:</label>
    <input type="text" name="dis1"><br>
    <label>Distancia 2:</label>
    <input type="text" name="dis2"><br>
    <label>Distancia 3:</label>
    <input type="text" name="dis3"><br>
    <label>Distancia 4:</label>
    <input type="text" name="dis4"><br>
    <label>Distancia 5:</label>
    <input type="text" name="dis5"><br>
    <input type="submit" name="sumar"><br>

    </body>

    <?php
    
    $numero1 = $_POST['dis1'];
    $numero2 = $_POST['dis2'];

    $suma = (DOUBLE)$numero1 + (DOUBLE)$numero2;
    $suma = (DOUBLE)$suma;

    echo "la suma es : " + $suma;
    ?>
</html>