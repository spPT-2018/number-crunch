//
// Created by Malte on 24/01/2019.
//

#ifndef NUMBER_CRUNCH_TEST_IMPLEMENTATIONS_HPP
#define NUMBER_CRUNCH_TEST_IMPLEMENTATIONS_HPP

#include <string>

using namespace std;

class TestImplementations {
public:
    static double matrix2dMultiplier(int size);
    static double characterCount(std::string str);
    static unsigned int piDigits(int digits);
    static int fibonacciDigits(int digits);
    static double primes(int digits);
};


#endif //NUMBER_CRUNCH_TEST_IMPLEMENTATIONS_HPP
