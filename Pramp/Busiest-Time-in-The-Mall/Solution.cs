using System;

class Solution
{
  public static int FindBusiestPeriod(int[,] data)
  {

    int count = 0;  int maxCount =0; int period=0; 
    int rows = data.GetLength(0);

    for (int i =0; i< rows; i++)
    {
      if(data[i,2] == 1) count += data[i,1];
     else count -= data[i,1];
      
      if(i +1 <rows && data[i,0] == data[i+1,0]) continue;
      
      if(count > maxCount){
        maxCount = count;
        period = data[i,0];
      }
    }
    return period;
  }

  static void Main(string[] args)
  {

  
  }
}

