#include <bits/stdc++.h>
using namespace std;

int main() {
    int t;
    cin >> t;
    while (t--) {
        int n;
        cin >> n;
        vector<pair<int, int>> activities;
        for (int i = 0; i < n; i++) {
            int n, m;
            cin >> n >> m;
            activities.push_back({n, m});
        }
        sort(activities.begin(), activities.end(), [](const auto& a, const auto& b) {
            return a.second < b.second;});
        
        int finish = 0, count = 0;
        vector<pair<int, int>>::iterator it = activities.begin();
        while (it != activities.end()) {
            if (it->first < finish)
                it++;
            else {
                finish = it->second;
                count++;
            }
        }
        cout << count << endl;
    }
}