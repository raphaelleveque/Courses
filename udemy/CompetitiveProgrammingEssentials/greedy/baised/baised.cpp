#include <bits/stdc++.h>
using namespace std;

int main() {
    long long t; // Alterado de int para long long
    cin >> t;
    while (t--) {
        long long n; // Alterado de int para long long
        cin >> n;
        vector<pair<long long, string>> teams; // Alterado de int para long long
        for (long long i = 0; i < n; i++) { // Alterado de int para long long
            string a;
            long long b; // Alterado de int para long long
            cin >> a >> b;
            teams.push_back({b, a});
        }
        sort(teams.begin(), teams.end());
        long long count = 0; // Alterado de int para long long
        for (long long i = 0; i < teams.size(); i++) { // Alterado de int para long long
            count += abs(teams[i].first - (i + 1));
        }
        cout << count << endl;
    }
}
