#include "Array.cpp"
// #include "Array.h" -> nao compila
int main() {
    Array<char> arr;
    arr.append('A');
    arr.append('B');
    arr.append('C');
    arr.append('D');
    arr.append('E');
    arr.append('F');
    arr.display();
    arr.reverse();
    arr.display();
    cout << (char)arr.min() << endl;

    return 0;
}
