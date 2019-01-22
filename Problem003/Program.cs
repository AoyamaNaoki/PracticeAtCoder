using System;

namespace Problem003
{
    class Program
    {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < input.Length; i++){
                if('1' == input[i]){
                    total += 1;
                }    
            }
            Console.Write(total);
        }
    }
}
