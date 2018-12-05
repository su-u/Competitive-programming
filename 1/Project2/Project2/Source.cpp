#include<iostream>
using namespace std;
int main() {
    int a,b;
    cin >> a >> b;
    if ((a*b) & 1) {
        cout << "Odd" << endl;
    } else {
        cout << "Even" << endl;
    }
}