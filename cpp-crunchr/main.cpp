
#ifndef NATIVE_BENCHMARK8_H
#define NATIVE_BENCHMARK8_H

#include <iostream>
#include <functional>
#include <chrono>
#include <math.h>

#include "test_wrappers.hpp"

using namespace std;
using namespace std::chrono;

#define MIN_RUNNING_TIME 250 * 1000000
#define ITERATIONS 10

static double Benchmark8(string &&msg, function<double (int)> &&fun, int iterations, double minTime){
    int count = 1, totalCount = 0;
    double dummy = 0.0, runningTime = 0.0, deltaTime, deltaTimeSquared;
    do {
        count *= 2;
        deltaTime = 0.0;
        deltaTimeSquared = 0.0;
        for (auto j = 0; j < iterations; j++) {
            auto startTime = high_resolution_clock::now();
            for (auto i = 0; i < count; i++)
                dummy += fun(i);
            runningTime = duration_cast<nanoseconds>(high_resolution_clock::now() - startTime).count();
            double time = runningTime / count;
            deltaTime += time;
            deltaTimeSquared += time * time;
            totalCount += count;
        }
    } while (runningTime < minTime && count < INT32_MAX / 2);
    double mean = deltaTime/iterations, standardDeviation = sqrt((deltaTimeSquared - mean * mean * iterations) / (iterations - 1));
    cout << msg << "\t" << mean << "\t" << standardDeviation << "\t\t" << count << endl;
    return mean;
}




int main() {

    cout.precision(0);
    cout.setf(std::ios::fixed);

    cout << "Test name\tMean\tStd. dev.\tCount" << endl;

    auto score = 0.0;
    score += Benchmark8("matrixer   ", TestWrappers::matrixer, ITERATIONS, MIN_RUNNING_TIME);
    score += Benchmark8("lorem chars", TestWrappers::loremChars, ITERATIONS, MIN_RUNNING_TIME);
    score += Benchmark8("primes     ", TestWrappers::primeCrunch, ITERATIONS, MIN_RUNNING_TIME);
    score += Benchmark8("π-crunchr  ", TestWrappers::piCrunch, ITERATIONS, MIN_RUNNING_TIME);
    score += Benchmark8("fibonacci  ", TestWrappers::fibonacciCrunch, ITERATIONS, MIN_RUNNING_TIME);

    cout << "\n-- Your computers score is " << (int) (pow(score, -1) * 1000000000) << " --" << endl;
    return 0;
}
#endif //NATIVE_BENCHMARK8_H