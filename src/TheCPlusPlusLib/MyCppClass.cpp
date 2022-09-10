#include "pch.h"
#include "MyCppClass.h"

#include <iostream>
using namespace std;

class MyClass {

    /// <summary>
    /// The name of the object
    /// </summary>
    string name;

    /// <summary>
    /// A couple of integers
    /// </summary>
    int valueA, valueB;

public:

    /// <summary>
    /// This one has a comment here
    /// </summary>
    /// <param name=""></param>
    /// <param name=""></param>
    void setValues(int, int);
    int getValueA() { return valueA; }
    int getValuesMultiplied() { return valueA * valueB; }
};

void MyClass::setValues(int a, int b) {
    valueA = a;
    valueB = b;
}

int main() {
    MyClass myClass;
    myClass.setValues(3, 4);
    cout << "values Multiplied: " << myClass.getValuesMultiplied();
    return 0;
}

/// <summary>
/// This one has a comment here
/// </summary>
/// <returns></returns>
static int testMe() {
    return 3;
}