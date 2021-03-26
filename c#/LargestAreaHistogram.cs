using System;
using System.IO;
using System.Collections;


public static class GFG{
    public static T[] SubArray<T>(this T[] data, int index, int length)
{
    T[] result = new T[length];
    Console.WriteLine("index: {0} ,length:{1}",index, length);
    Array.Copy(data, index, result, 0, length);
    return result;
}
	static public void Main (){
		//Code
		Console.WriteLine("Enter number of rectangles");
		int rectCount = Convert.ToInt32(Console.ReadLine());
		int[] rectArray= new int[rectCount];
		for(int i =0; i< rectCount;i++){
		    Console.WriteLine("Enter length of rectangel {0}",i);
		    rectArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		


		Console.WriteLine("Calculating largest rectangle array");
		int largestArea = 0;
		for(int i=0; i<rectCount; i++){
		    int currArea = rectArray[i] * 1;
		    Console.WriteLine("current i:{0}", i);
		    for(int j=1; j<=rectCount-i ;j++){
		        int[] subArray;
		        if(i == 0){
		        subArray = rectArray.SubArray(i, j);
		        }else{
		         subArray = rectArray.SubArray(i, j);   
		        }

		        Array.Sort(subArray);
                Console.WriteLine(String.Join(",", subArray));
		        currArea = Math.Max(currArea, subArray[0] * subArray.Length) ;
		       Console.WriteLine("currArea: {0}", currArea);
		        if(currArea > largestArea){
		            largestArea = currArea;
		        }
		    }
		}
		Console.WriteLine("largestArea: {0}", largestArea);
		
	
	}
}
