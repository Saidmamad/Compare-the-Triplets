using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {


    static int[] getPoint(int a, int b, ref int scoreA, ref int scoreB) {
        if (isValidParam(a, b))
            {
                if(a>b){
                   scoreA+=1;
                }
                else if(b>a){
                    scoreB+=1;
                }
            
            } else {
                Console.WriteLine("The score value should be between 0 and 100");
            }
        int[] rez = {scoreA,scoreB};
        
        return rez;
    }

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        public static int scoreA = 0;
        public static int scoreB = 0;

        int[] result = new int[0];
        result[] += getPoint(a0, b0, ref scoreA, ref scoreB);
        result[] += getPoint(a1, b1, ref scoreA, ref scoreB);
        result[] += getPoint(a1, b1, ref scoreA, ref scoreB);

        
        int[] result = {scoreA,scoreB};
        
        return result;
    }

    
    static bool isValidParam(int x, int y){

        return (x >= 0 && x <= 100 && y >= 0 && y <= 100);
        
    }

    
    
    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));

        Console.ReadLine();
    }

}

