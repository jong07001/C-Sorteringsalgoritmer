using System;
using System.Collections.Generic;
using System.Diagnostics;


        
List<int> randomNumbers = new List<int>();
Random random = new Random();

Console.WriteLine("Unsorted list:");
for(int i = 0; i<100000; i++){
    int randomNumber = random.Next(1,100000);
    randomNumbers.Add(randomNumber);
}
foreach(int number in randomNumbers){
    Console.WriteLine(number);
}
Console.WriteLine("Sorted List:");
Stopwatch sw = Stopwatch.StartNew();
int a,b;
for(a = 0; a<randomNumbers.Count-1; a++){
    int bM = a;
    for(b=a+1;b<randomNumbers.Count; b++){
        if(randomNumbers[b]<randomNumbers[bM]){
            bM=b;
        }
    }
        int t = randomNumbers[a];
        randomNumbers[a]=randomNumbers[bM];
        randomNumbers[bM]=t;
}sw.Stop();
foreach(int number in randomNumbers){
    Console.WriteLine(number);
}

 Console.WriteLine("Elapsed Time: {0}ms", sw.ElapsedMilliseconds);