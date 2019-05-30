using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int[] socksPile) {
        var pairsFound = 0;
        var sockColorHash = new Dictionary<int, int>();

        foreach (var sock in socksPile) {
            if (sockColorHash.ContainsKey(sock)) {
                pairsFound++;
                sockColorHash.Remove(sock);
            }
            else
                sockColorHash.Add(sock, 1);
        }
        return pairsFound;
    }

    static void Main(String[] args) {
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        var result = sockMerchant(arr);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}