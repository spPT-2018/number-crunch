
#include "test_implementations.hpp"

#include <string>
#include <unordered_map>
#include <vector>
#include <math.h>

double TestImplementations::matrix2dMultiplier(int size)
{
    float array1[size][size]{};
    float array2[size][size]{};

    for (auto i = 0; i < size; i++)
    {
        for (auto j = 0; j < size; j++)
        {
            array1[i][j] = i;
            array2[i][j] = size - i;
        }
    }

    auto sum = 0.0;

    for (auto i = 0; i < size; i++)
    {
        for (auto j = 0; j < size; j++)
        {
            sum += array1[i][j] * array2[i][j];
        }
    }

    return sum;
}

double TestImplementations::characterCount(std::string str)
{
    auto dict = std::unordered_map<char, int>();

    for (auto ch : str)
    {
        dict[ch] = 1;
    }

    return dict.size();
}

unsigned int TestImplementations::piDigits(int digits)
{
    digits++;
    auto length = digits*10/3+2;
    unsigned int x[length]{};
    unsigned int r[length]{};
    unsigned int pi[digits]{};

    for (auto j = 0; j < digits; j++)
        x[j] = 20;

    for (auto i = 0; i < digits; i++)
    {
        unsigned int carry = 0;
        for (auto j = 0; j < length; j++)
        {
            auto num = (unsigned int)(length - j - 1);
            unsigned int dem = num * 2 + 1;

            x[j] += carry;

            unsigned int q = x[j] / dem;
            r[j] = x[j] % dem;

            carry = q * num;
        }


        pi[i] = (x[length-1] / 10);


        r[digits - 1] = x[length - 1] % 10; ;

        for (auto j = 0; j < length; j++)
            x[j] = r[j] * 10;
    }

    unsigned int c = 0;

    for(auto i = digits - 1; i >=0; i--)
    {
        pi[i] += c;
        c = pi[i] / 10;
    }

    return c;
}

int TestImplementations::fibonacciDigits(int digits)
{
    int a = 0, b = 1, c = 0;
    for (auto i = 2; i < digits; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c;
}

double TestImplementations::primes(int digits)
{
    bool A[digits + 1]{};

    for (auto i = 2; i < digits + 1; i++)
    {
        A[i] = true;
    }

    for (auto i = 2; i < sqrt(digits); i++)
    {
        if(A[i])
        {
            auto iPow = (int) pow(i, 2);
            auto num = 0;

            for (auto j = 0; j < digits; j = iPow + num * i)
            {
                A[i] = false;
                num++;
            }
        }
    }

    auto primeSum = 0;
    for (auto i = 2; i < digits + 1; i++)
    {
        if (A[i])
            primeSum += i;
    }

    return primeSum;
}
