cmake_minimum_required(VERSION 3.20)
project(ArrayADT)

set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -Wall -Wextra -Werror")

add_executable(ArrayADT main.cpp Array.h Array.cpp Array.h)

