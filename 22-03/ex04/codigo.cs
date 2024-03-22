using System;

public class BinaryCalculator
{
    public static int ToBinary(int num) {
        string result = "";
        int[] binaryNum = new int[32];

        int i = 0;
        for (;num > 0; i++) {
            binaryNum[i] = num % 2;
            num /= 2;
        }
        
        for (int j = i - 1; j >= 0; j--)
            result += binaryNum[j];
            
        return Convert.ToInt32(result);
    }
    
    public static int ToDecimal(int num) {
        int dec_value = 0;
        int base1 = 1;
        
        int temp = num;
        
        for (;temp > 0; base1 *= 2) {
            int last_digit = temp % 10;
            temp = temp / 10;
 
            dec_value += last_digit * base1;
        }
 
        return dec_value;
    }
    
    public static void Main(string[] args) {
        Console.Write("Digite o numero a ser convertido: \n");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Que conversao deseja fazer?\n0 - Decimal -> Binario\n1 - Binario -> Decimal\n");
        string choice = Console.ReadLine();
        
        if (choice == "1") 
            Console.Write(ToDecimal(num));
        else if (choice == "0")
            Console.Write(ToBinary(num));
        else
            return;
    }
}