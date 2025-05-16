<?php

require "./db/user.php";
try {
    if($_SERVER['REQUEST_METHOD'] == "POST") {
        $user = new User();

        $email = htmlspecialchars($_POST['email']);
        $password = htmlspecialchars($_POST['password']);

        $userData = $user->login($email);
            if($userData && password_verify($password, $userData['password'])) {
                session_start();
                $_SESSION['login_status'] = true; 
                $_SESSION['name'] = $userData['name'];
                header("Location: Homepagina.html");

            } else {
                echo "Ongeldig email of wachtwoord!";
                header("refresh:2, url = inlog.php");
                die();
            }
        }
    } catch (Exception $e) {
        echo $e->getMessage();
    }

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        #form {
            max-width: 600px;
            margin: 0 auto;
        }
    </style>
    <link rel="stylesheet" href="style1.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <title>Document</title>
</head>
<body>
<header>
<nav>
    <a href="About.html">About</a>
    <a href="Homepagina.html">Browse</a>
    <a href="Cart.html">Cart</a>
    <a href="inlog.php">Login</a>
    <a href="registreren.php">Register</a>
</nav>
<h1>Books2day</h1>
</header>
<form action="Homepagina.html" method="POST" id="form">
<div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="text" class="form-control" name="email" placeholder="Email" required>
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputName1" class="form-label">Name</label>
    <input type="text" class="form-control" name="name" placeholder="Name" required> 
 </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" name="password" placeholder="Password" required>
  </div>
  <button type="submit">Login</button>
</form>
</body>
</html>
