#include<bits/stdc++.h>
using namespace std;

int minTaps(int n, vector<int> ranges) {
    // <range[i], i>
    vector<pair<int, int>> taps(ranges.size());
    for(int i = 0; i < ranges.size(); i++) {
        taps.at(i) = {ranges.at(i), i};
    }
    sort(taps.begin(), taps.end(), greater<pair<int, int>>());
    int count = 0;
    int minCovered = taps.size();
    int maxCovered = -1;
    for (int j = 0; j < taps.size(); j++) {
        if (taps.at(j).second + taps.at(j).first > maxCovered) {
            count++;
            maxCovered = taps.at(j).second + taps.at(j).first;

            if (taps.at(j).second - taps.at(j).first < minCovered)
                minCovered = taps.at(j).second - taps.at(j).first;
        } else if (taps.at(j).second - taps.at(j).first < minCovered && minCovered > 0) {
            count++;
            minCovered = taps.at(j).second - taps.at(j).first;
        }
    }
    return count;
}

int main() {
    vector<int> ranges = {3,4,1,1,0,0};
    minTaps(5, ranges);
}