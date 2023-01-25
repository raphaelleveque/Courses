#include "Array.h"
#include <climits>

template<typename T>
Array<T>::Array(int sz, T initialized) {
    max_size = sz;
    length = sz;
    arr = new T[max_size];
    for (int i = 0; i < sz; ++i) {
        arr[i] = initialized;
    }
}

template<typename T>
Array<T>::Array() {
    max_size = 2;
    length = 0;
    arr = new T[max_size];
    for (int i = 0; i < 2; ++i) {
        arr[i] = 0;
    }
}

template<typename T>
Array<T>::~Array() {
    delete[]arr;
}

template<typename T>
void Array<T>::display() {
    for (int i = 0; i < length; ++i) {
        cout << arr[i] << " ";
    }
    cout << endl;
}

template<typename T>
T &Array<T>::operator[](int index) {
    if (index >= max_size) {
        cout << "Array index out of bound, exiting";
        exit(0);
    }
    return arr[index];
}

template<typename T>
void Array<T>::append(T x) {
    if (length == max_size) {
        max_size *= 2;
        T *tmp = new T[max_size];
        copy(arr, arr + length, tmp);
        delete[]arr;
        arr = tmp;
    }
    arr[length] = x;
    length++;
}

template<typename T>
void Array<T>::insert(int index, T x) {
    if (index < 0 || index > length) return;
    if (length == max_size) {
        max_size *= 2;
        T *tmp = new T[max_size];
        copy(arr, arr + length, tmp);
        delete[]arr;
        arr = tmp;
    }
    for (int i = length; i > index; i--)
        arr[i] = arr[i - 1];
    arr[index] = x;
    length++;
}

template<typename T>
void Array<T>::erase(int start, int last) {
    if (start >= length || start < 0) return;
    if (last == -1) {
        for (int i = start; i < length - 1; ++i) {
            arr[i] = arr[i + 1];
        }
        arr[length - 1] = 0;
        length--;
    } else {
        if (last < start || last > length) return;
        for (int i = start; i < length - 1; ++i) {
            if (i + (last - start) > length - 1)
                arr[i] = 0;
            else
                arr[i] = arr[i + (last - start)];
        }
        length -= (last - start);
    }
}

template<typename T>
int Array<T>::size() {
    return length;
}

template<typename T>
int Array<T>::find(T key) {
    for (int i = 0; i < length; ++i) {
        if (arr[i] == key)
            return i;
    }
    return -1;
}

template<typename T>
int Array<T>::binary_search(T key) {
    int mid;
    int left = 0, right = length - 1;

    while (left <= right) {
        mid = (left + right) / 2;
        if (arr[mid] == key)
            return mid;
        else if (arr[mid] < key) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    return -1;
}

template<typename T>
int Array<T>::max() {
    int max = INT_MIN;
    for (int i = 0; i < length; ++i) {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

template<typename T>
int Array<T>::min() {
    int min = INT_MAX;
    for (int i = 0; i < length; ++i) {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

template<typename T>
int Array<T>::isSorted() {
    for (int i = 0; i < length - 1; ++i) {
        if (arr[i] > arr[i + 1])
            return false;
    }
    return true;
}


template<typename T>
int Array<T>::sorted_insertion(T x) {
    if (isSorted() == -1)
        return -1;

    if (length == max_size) {
        max_size *= 2;
        T *tmp = new T[max_size];
        copy(arr, arr + length, tmp);
        delete[]arr;
        arr = tmp;
    }
    int i;
    for (i = length; i > 0; i--) {
        if (x < arr[i - 1])
            arr[i] = arr[i - 1];
        else {
            arr[i] = x;
            break;
        }
    }
    if (i == 0)
        arr[i] = x;
    length++;
}

template<typename T>
void Array<T>::reverse() {
    T tmp;
    for (int i = 0, j = length - 1; i < j; ++i, --j) {
        tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}