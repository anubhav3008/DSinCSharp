// ReverseSentence.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

/*
* PRG_0012
Given a String S, reverse the string without reversing its individual words. Words are separated by dots.
Input:
S = i.like.this.program.very.much
Output: much.very.program.this.like.i
Explanation: After reversing the whole
string(not individual words), the input
string becomes
much.very.program.this.like.i
* 
*/

#include <iostream>
#include <stdio.h>
using namespace std;

void reverseWord(string &s, size_t i, size_t j) {
    while (i < j) {
        char temp = s[i];
        s[i] = s[j];
        s[j] = temp;
        i++;
        j--;
    }
}

}


int main()
{
    string s = "i.like.this.program.very.much";
    reverseSentence(s);
    cout << s + "\n";

    s = "my.name.is.anubhav";
    reverseSentence(s);
    cout << s + "\n";

}
