import java.util.Scanner;
public class Main
{
	public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
	    
		System.out.println("Ilk reqem: ");
		int a = sc.nextInt();
		
		System.out.println("Ikinci reqem: ");
		int b = sc.nextInt();
		
		System.out.println("Toplam: " + Calc(a, b));
	}
	
	public static int Calc(int a, int b){
	    return a+b;
	}
}
