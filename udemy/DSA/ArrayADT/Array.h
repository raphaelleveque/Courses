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
    Array(int sz, T initialized = 0);
    Array();
    ~Array();
    T& operator[](int index);
    void display();
    void append(T x);
    void insert(int index, T x);
    void erase(int start, int last = -1);
    int size();
    int find(T key);
    int binary_search(T key);
    int max();
    int min();
    int isSorted();
    int sorted_insertion(T x);
    void reverse();
    Array<T> merge(Array<T> &arr2);

    // Union operation only works with sets, that means, with unique elements
    Array<T> Union(Array<T> &arr2);
    // Difference operation only works with sets, that means, with unique elements
    Array<T> Difference(Array<T> &arr2);
};

#include "Array.cpp"

#endif //ARRAYADT_ARRAY_H

