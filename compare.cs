/* Is there any other way to solve this problem?
*  It just compares two scores, the scores of person A, who has 3 marks, a0, a1, a2, b0, b1, b2.  
*  If the score of a0 > b0, it should give to student A one point, and so on.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
   
    
    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        int scoreA = 0;
        int scoreB = 0;
        
        if(CheckParam(a0,b0)){
            if(a0>b0){
               scoreA+=1;
            }
            else if(b0>a0){
                scoreB+=1;
            }
            
        }else {
            Console.WriteLine("The score value should be between 0 and 100");
        }
        
        if(CheckParam(a1,b1)){
            if(a1>b1){
               scoreA+=1;
            }
            else if(b1>a1){
                scoreB+=1;
            }
            
        }else {
            Console.WriteLine("The score value should be between 0 and 100");
        }
        
        if(CheckParam(a2,b2)){
            if(a2>b2){
               scoreA+=1;
            }
            else if(b2>a2){
                scoreB+=1;
            }
            
        }else {
            Console.WriteLine("The score value should be between 0 and 100");
        }
        
        int[] result = {scoreA,scoreB};
        
        return result;
    }

    
    static bool CheckParam(int x, int y){
        if(x>=0 && x<=100 && y>=0 && y<=100)
        { 
            return true; 
        }
        else
        {
            return false;
        }
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
    }

}


