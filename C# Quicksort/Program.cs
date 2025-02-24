using System.Collections.Generic;
using System;
using System.Diagnostics;

List<int> randomNumbers = new List<int>();
int n = randomNumbers.Count;


Random random = new Random();

Console.WriteLine("unsorted list:");
for(int i = 0; i<=100000; i++){
    int randomNumber = random.Next(1,100001);
    randomNumbers.Add(randomNumber);
}
Console.WriteLine("unsorted list:");
foreach(int number in randomNumbers){
    Console.WriteLine(number);
}
Console.WriteLine("sorted list:");
Stopwatch sw = Stopwatch.StartNew();
quicksort(randomNumbers, 0, randomNumbers.Count -1);
sw.Stop();
foreach(int number in randomNumbers){
    Console.WriteLine(number);
}
Console.WriteLine("Elapsed Time: {0}ms", sw.ElapsedMilliseconds);


 static int partition(List<int> randomNumbers, int low, int high){
        int pivot = randomNumbers[low];
        int a = low - 1, b = high + 1;

        while (true){
            do{
                a++;
            } while (randomNumbers[a] < pivot);
            do{
                b--;
            }while(randomNumbers[b]>pivot);
            if(a >= b)
                return b;
                swap(randomNumbers, a, b);
        }    
    }
    int partition2(List<int> randomNumbers, int low, int high){
        Random randomA = new Random();
        int randomB = low + randomA.Next(high-low);
        swap(randomNumbers, randomB, low);
        return partition(randomNumbers, low, high);
    }
    
    void quicksort(List<int> randomNumbers, int low, int high){
        if(low<high){
            int p = partition2(randomNumbers, low, high);

            quicksort(randomNumbers, low, p);
            quicksort(randomNumbers, p + 1, high);
        }
    }

 static void swap(List<int> randomNumbers, int a, int b){
    int t = randomNumbers[a];
    randomNumbers[a] = randomNumbers[b];
    randomNumbers[b] = t;
}