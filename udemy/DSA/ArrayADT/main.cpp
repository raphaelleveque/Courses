#include "Array.h"
// In order to run, only compile main.cpp, do not compile Array.cpp

int main() {
    Array<int> arr;
    arr.sorted_insertion(4);
    arr.sorted_insertion(5);
    arr.sorted_insertion(6);
    arr.sorted_insertion(0);
    arr.sorted_insertion(7);

    Array<int> arr2;
    arr2.sorted_insertion(11);
    arr2.sorted_insertion(9);
    arr2.sorted_insertion(4);
    arr2.sorted_insertion(7);
    arr2.sorted_insertion(19);

    arr.display();
    arr2.display();

    (arr.Difference(arr2)).display();

    return 0;
}
