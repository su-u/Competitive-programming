#include<iostream>
#include<string>
using namespace std;

int main() {
    string s;
    cin >> s;
    int a = std::atoi(s.c_str()),b = 0;
    if(a & 1)b =1;
    if (a & 0b10)++b;
    if (a & 0b100000)++b;
    cout << b << endl;
    return 0;
}