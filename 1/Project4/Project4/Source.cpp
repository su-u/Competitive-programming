#include<iostream>
using namespace std;

int main() {
    int n;
    int a[210] = {0};
    int ans = 0;
    cin >> n;
    for (int i = 0; i < n; ++i) {
        cin >> a[i];

    }

    int c = 0;
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < a[i]; ++j) {
            if ((a[i] & 1) && c < j){
                c = j;
                cout << "c=" << j << endl;
                break;
            }else{
                a[i] >>= 1;
            }
        }
    }
    for (int i = 0; i < c; ++i) {

        c <<= 1;
    }
    
    cout << c << endl;
}