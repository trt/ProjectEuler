using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSumOfMultiplesOf3Or5BelowN(n));
        }
    }
    
    private static int GetSumOfMultiplesOf3Or5BelowN(int n){
        var sum = Enumerable.Range(0, n).Where(number => number % 3 == 0 || number % 5 == 0).Sum();
        return sum;
    }
}