#include <bits/stdc++.h>
using namespace std;
#define ll long long

int main() {
    int tests;
    cin >> tests;
    while (tests--) {
        int w, h, n;
        cin >> w >> h >> n;
        if (n == 0) {
            cout << w * h << endl;
            return 0;
        }
        vector<pair<int, int>> coord(n);
        for (int i = 0; i < n; i++) {
            cin >> coord.at(i).first >> coord.at(i).second;
        }
        sort(coord.begin(), coord.end());
        int maxArea = 0;
        for (int i = 1; i < n; i++) {
            int area = abs((coord.at(i).first - coord.at(i - 1).first)) * abs((coord.at(i).second - coord.at(i - 1).second));
            if (area > maxArea)
                maxArea = area;
        }
        cout << maxArea << endl;
    }
    
}