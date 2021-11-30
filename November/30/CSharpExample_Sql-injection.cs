using System;

class HelloWorld {
  static void Main() {
    Console.WriteLine("Ilk reqem: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Ikinci reqem: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Toplam: " + Calc(a, b));
    List<Users> users = new List<Users>();
    
    string username = "abc";
    string password =  "abc; delete from Users;";
    users.Where(m => m.Username == username && Password == password);
    
  }
  
  public static int Calc(int a, int b){
      return a+b;
  }
  
  public class User{
      public string Username {get;set;}
      public string Password {get;set;}
  }
}
