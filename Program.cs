
using System.Collections;
using System;

namespace wk1CodeChallengeProblem1
{
    class Program{
        static void Main()
        {
            int[] num1 = {1,3};
            int[] num2 ={2};
            float medianOfExample1 = Median.findMedian(num1, num2);
            Console.WriteLine("the median of example 1 is equal to:" + medianOfExample1);
            
            int[] num3 = {1, 2};
            int[] num4 = {3, 4};
            float medianOfExample2 = Median.findMedian(num3, num4);
            Console.WriteLine("the median of example 2 is equal to:" + medianOfExample2);

        }
    }

    public class Median
    {
        public static float findMedian(int[] num1, int[] num2)
        {
            int i=0;
            int j=0;
            //int k =0;
            float med1 = -400;
            float med2  = -400;
            int n= num1.Length;
            int m = num2.Length; 

            if((m+n)%2!=0){ // when n+m is odd
                for(int k = 0; k<=(n+m)/2; k++)
                {
                    if(i!= n && j!= m)
                    {
                       if(num1[i]>num2[j])
                          med1 = num2[j++];
                       else
                          med1 = num1[i++]; 

                    }else if(i<n)
                    {
                        med1 = num1[i++];
                    }
                    else //if j<m
                    {
                        med1 = num2[j++];
                    }
                }
                return med1;
            }
            else // if m+n is even
            {
                for(int k =0; k<=(n+m)/2; k++)
                {
                    med2 = med1;
                    if(i!= n && j!=m)
                    {
                        if (num1[i]>num2[j])
                            med1 = num2[j++];
                        else
                            med1 = num1[i++];
                    }
                    else if(i<n)
                    {
                        med1 = num1[i++];
                    }
                    else{
                        med1=num2[j++];
                    }
                }
                return ((med1+med2)/2);
            }
        }
    } 
}