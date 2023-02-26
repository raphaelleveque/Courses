#include "Array.h"
// In order to run, only compile main.cpp, do not compile Array<int>.cpp

int main() {
    Array<int> arr;
    while (1) {
        cout << "1) append   " << "2) insert   " << "3) pop_back   " << "4) sorted insertion   " << "5) delete "
             << endl << endl;
        cout << "6) find   " << "7) getSize   " << "8) binary_search   " << "9) is it sorted?   "
             << "10) access an element " << endl << endl;
        cout << "11) display   " << "12) max element   " << "13) min element   " << "14) reverse array   "
             << "15) merge two arrays " << endl << endl;
        cout << "0) exit" << endl << endl;
        int input;
        int index;
        int pos, pos2;
        int data;
        cin >> input;

        if (input == 1) {
            cout << endl;
            cout << "Enter data: ";
            cin >> data;
            arr.append(data);
            cout << endl;
            cout << arr << endl << endl;
        } else if (input == 2) {
            cout << endl;
            cout << "Enter index(1 is first element): ";
            cin >> index;
            cout << "Enter data: ";
            cin >> data;
            arr.insert(index, data);
            cout << endl;
            cout << arr << endl << endl;
        } else if (input == 3) {
            arr.pop_back();
            cout << endl;
            cout << arr << endl << endl;
        } else if (input == 4) {
            cout << endl;
            cout << "Enter data: ";
            cin >> data;
            arr.sorted_insertion(data);
            cout << endl;
            cout << arr << endl << endl;
        } else if (input == 5) {
            cout << endl << arr << endl;
            cout << "What range of indexes do you wish to erase [)? " << endl;
            cin >> pos >> pos2;
            arr.erase(pos, pos2);
            cout << arr << endl;
        } else if (input == 6) {
            cout << endl << "What key do you wish to find in the array?" << endl;
            cin >> input;
            int findvar = arr.find(input);
            cout << (findvar == -1 ? "Key was not found" : "Key is in index " + to_string(findvar)) << endl;
        } else if (input == 7) {
            cout << endl;
            cout << "Size: " << arr.size() << endl << endl;
        } else if (input == 8) {
            cout << endl << "What key do you wish to find in the array? The array must be ordered!" << endl;
            cin >> input;
            int findvar = arr.binary_search(input);
            cout << (findvar == -1 ? "Key was not found" : "Key is in index " + to_string(findvar)) << endl;
        } else if (input == 9) {
            cout << endl;
            cout << (arr.isSorted() ? "The array is sorted " : "The array is not sorted") << endl;
        } else if (input == 10) {
            cout << endl;
            cout << "Enter position: ";
            cin >> pos;
            cout << endl;
            cout << arr[pos] << endl << endl;
        } else if (input == 11) {
            cout << endl;
            arr.display();
        }else if (input == 12) {
            cout << "Max element: " << arr.max() << endl;

        }else if (input == 13) {
            cout << "Min element: " << arr.min() << endl;

        }else if (input == 14) {
            cout << endl << arr << endl;
            arr.reverse();
            cout << arr << endl << endl;

        }else if (input == 15) {
            int newsize;
            cout << "How many elements do you wish in your new array? " << endl;
            cin >> newsize;
            Array<int> newarr;
            cout << "Enter your new array elements: " << endl;
            for (int i = 0; i < newsize; ++i) {
                cin >> input;
                newarr.append(input);
            }
            cout << "Your new array: " << newarr << endl;
            cout << "Your old array: " << arr << endl;
            cout << "Merging arrays..." << endl;
            Array<int> mergedArray = arr.merge(newarr);
            cout << endl << "Your merged array:   " << mergedArray << endl;

        }else if (input == 0) {
            return 0;
        } else {
            cout << endl;
            cout << "Wrong input!" << endl << endl;
        }
    }
    return 0;
}
