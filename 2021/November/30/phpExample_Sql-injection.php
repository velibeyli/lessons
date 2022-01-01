<?php 
$a = readline('Ilk reqem: ');
$b = readline('Ikinci reqem: ');

echo "Toplam: " . Calc($a, $b);

function Calc($a, $b){
    return $a + $b;
}

$userId = $_POST['userId'];

$queryResult = mysql_db_query('select * from Users where UserId = $userId');

$queryResult = mysql_db_query('delete from Users where UserId = $userId');

$username = $_POST['username']; //orkhan@gmail.com
$password = $_POST['password']; //abc123456

$queryResult = mysql_db_query('select * from Users where Username = $username && Password = $password');
$queryResult = mysql_db_query('select * from Users where Username = orkhan@gmail.com && Password = abc123456');

$username = $_POST['username']; //abc
$password = $_POST['password']; //abc;delete from Users;
$queryResult = mysql_db_query('select * from Users where Username = abc && Password = abc;delete from Users;');
//PHP: select * from Users where Username = abc && Password = abc;delete from Users;
//C#:  select * from Users where Username == 'abc' and Password == 'abc; delete from Users;';

?>
