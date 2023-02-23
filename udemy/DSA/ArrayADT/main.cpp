#include "Array.cpp"
// #include "Array.h" -> nao compila

int main() {
    Array<int> arr;
    arr.sorted_insertion(-4);
    arr.sorted_insertion(5);
    arr.sorted_insertion(6);
    arr.sorted_insertion(0);
    arr.sorted_insertion(-6);

    Array<int> arr2;
    arr2.sorted_insertion(-11);
    arr2.sorted_insertion(9);
    arr2.sorted_insertion(54);
    arr2.sorted_insertion(1);
    arr2.sorted_insertion(-10);

    arr.display();
    arr2.display();

    Array<int> arr3 = arr.merge(arr2);
    arr3.display();

    return 0;
}
