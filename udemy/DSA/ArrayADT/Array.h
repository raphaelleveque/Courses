#ifndef ARRAYADT_ARRAY_H
#define ARRAYADT_ARRAY_H
#include <iostream>
using namespace std;

template <typename T>
class Array {
private:
    T *arr;
    int max_size;
    int length;
public:
    // Constructor with size and value to initialize array
    Array(int sz, T initialized = 0);
    Array();
    ~Array();
    // Function to access an element of the array
    T& operator[](int index);
    void display();
    // Adds an element to the end of the array
    void append(T x);
    // Removes an element at the end of the array
    void pop_back();
    // Inserts an element in given index
    void insert(int index, T x);
    // Erases a range of elements, within a range of [start, end), with the end position not inclusive
    void erase(int start, int last = -1);
    int size();
    // Find a key and returns the index
    int find(T key);
    // Find a key and returns the index using binary search, so the array must be ordered
    int binary_search(T key);
    int max();
    int min();
    bool isSorted();
    // Inserts an element in a sorted array
    int sorted_insertion(T x);
    // Reverse the array
    void reverse();
    // Merge two arrays together
    Array<T> merge(Array<T> &arr2);

    // Union operation only works with sets, that means, with unique elements
    Array<T> Union(Array<T> &arr2);
    // Difference operation only works with sets, that means, with unique elements
    Array<T> Difference(Array<T> &arr2);

    // Prints an array using cout << array
    template<typename U>
    friend ostream &operator<<(ostream &os, const Array<U> &arr);
};

#include "Array.cpp"

#endif //ARRAYADT_ARRAY_H

