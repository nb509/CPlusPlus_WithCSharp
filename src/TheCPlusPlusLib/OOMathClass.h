#pragma once

#if _MSC_VER
#define DLLEXPORT __declspec(dllexport)  // See here: https://docs.microsoft.com/en-us/cpp/build/linking-an-executable-to-a-dll?view=msvc-170
#else
#define DLLEXPORT
#endif

class OOMathClass
{
private:
	int mRunningTotal; // Would be a good example make this an array, even thoug its not necessary?
public:
	OOMathClass();  // ctor
	~OOMathClass(); // dtor
	int Count;
	void Add(int number);
	int GetSum();
};

/// <summary>
/// This is our constructor, we return it only as a pointer (hence the *)
/// </summary>
extern "C" DLLEXPORT OOMathClass * MathObjectConstructor() { return new OOMathClass(); }

/// <summary>
/// This is our destructor, we take the pointer and call delete
/// </summary>
extern "C" DLLEXPORT void MathObjectDestructor(OOMathClass * pOOMathClass) { delete pOOMathClass; }


/// <summary>
/// This just returns the value count field
/// </summary>
extern "C" DLLEXPORT int MathObject_GetCount(OOMathClass * pOOMathClass) { return pOOMathClass -> Count; }


/// <summary>
/// Adds a number
/// </summary>
extern "C" DLLEXPORT void MathObject_Add(OOMathClass * pOOMathClass, int number) { pOOMathClass->Add(number); }