cmake_minimum_required(VERSION 3.10)
project(number_crunch)

set(CMAKE_CXX_STANDARD 14)

add_executable(number_crunch main.cpp test_implementations.hpp test_implementations.cpp)