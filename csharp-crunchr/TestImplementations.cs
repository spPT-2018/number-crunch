using System;
using System.Collections.Generic;

namespace pi_cruncher
{
    static class TestImplementations
    {
        
        public static double MatrixMultiplier(int size)
        {
            var array1 = new float[size, size];
            var array2 = new float[size, size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    array1[i, j] = i;
                    array2[i, j] = size - i;
                }
            }

            var sum = 0.0;
            
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    sum += array1[i, j] * array2[i, j];
                }
            }

            return sum;
        }
        
        public static double CharacterCount(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                dict[ch] = 1;
            }

            return dict.Count;
        }
        
        public static uint PiDigits(int digits)
        {   
            digits++;
        
            var x = new uint[digits*10/3+2];
            var r = new uint[digits*10/3+2];
        
            var pi = new uint[digits];
        
            for (var j = 0; j < x.Length; j++)
                x[j] = 20;
        
            for (var i = 0; i < digits; i++)
            {
                uint carry = 0;
                for (var j = 0; j < x.Length; j++)
                {
                    var num = (uint)(x.Length - j - 1);
                    var dem = num * 2 + 1;
        
                    x[j] += carry;
        
                    var q = x[j] / dem;
                    r[j] = x[j] % dem;
        
                    carry = q * num;
                }
        
        
                pi[i] = (x[x.Length-1] / 10);
        
        
                r[x.Length - 1] = x[x.Length - 1] % 10; ;
        
                for (var j = 0; j < x.Length; j++)
                    x[j] = r[j] * 10;
            }
            
            uint c = 0;
        
            for(var i = pi.Length - 1; i >=0; i--)
            {
                pi[i] += c;
                c = pi[i] / 10;
        
            }
        
            return c;
        }
        
        public static int FibonacciDigits(int digits)  
        {  
            int a = 0, b = 1, c = 0;  
            for (var i = 2; i < digits; i++)  
            {  
                c = a + b;
                a = b;  
                b = c;  
            }

            return c;
        }  
        
        public static double Primes(int digits)
        {
            var A = new bool[digits + 1];
            
            for (var i = 2; i < digits + 1; i++)
            {
                A[i] = true;
            }

            for (var i = 2; i < Math.Sqrt(digits); i++)
            {
                if(A[i])
                {
                    var iPow = (int) Math.Pow(i, 2);
                    var num = 0;

                    for (var j = 0; j < digits; j = iPow + num * i)
                    {
                        A[i] = false;
                        num++;
                    }
                }
            }

            var primeSum = 0;
            for (var i = 2; i < A.Length; i++)
            {
                if (A[i])
                    primeSum += i;
            }

            return primeSum;
        }
    }
}