using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

List<int> randomNumbers = new List<int>();
List<int> sorted;
Random random = new Random();

Console.WriteLine("Unsorted list:");
for(int i = 0; i<=100000; i++){
    int randomNumber = random.Next(1,100001);
    randomNumbers.Add(randomNumber);
}
foreach(int number in randomNumbers){
    Console.WriteLine(number);
}

Console.WriteLine("Sorted list:");
Stopwatch sw = Stopwatch.StartNew();

sorted = Mergesort(randomNumbers);
sw.Stop();
foreach(int number in sorted){
    Console.WriteLine(number);
}
Console.WriteLine("Elapsed Time: {0}ms", sw.ElapsedMilliseconds);



List<int> Mergesort(List<int> randomNumbers){
    if(randomNumbers.Count <= 1){
    return randomNumbers;
}
    List<int> left = new List<int>();
    List<int> right = new List<int>();
    int middle = randomNumbers.Count/2;

    for(int i = 0; i<middle; i++){
        left.Add(randomNumbers[i]);
    }
    for(int i = middle; i<randomNumbers.Count; i++){
        right.Add(randomNumbers[i]);
    }
    left = Mergesort(left);
    right = Mergesort(right);
    return Merge(left,right);
}

List<int> Merge(List<int> left, List<int> right){
    List<int> result = new List<int>();
    int leftI = 0, rightI = 0;

    while(leftI < left.Count && rightI < right.Count){
        if(left[leftI] <= right[rightI]){
            result.Add(left[leftI]);
            leftI++;
        }
        else{
            result.Add(right[rightI]);
            rightI++;
        }
        
    }
    while(leftI < left.Count){
        result.Add(left[leftI]);
        leftI++;
    }
    while(rightI < right.Count){
        result.Add(right[rightI]);
        rightI++;
    }
    return result;
}