#pragma once

#if _MSC_VER
#define DLLEXPORT __declspec(dllexport)  // See here: https://docs.microsoft.com/en-us/cpp/build/linking-an-executable-to-a-dll?view=msvc-170
#else
#define DLLEXPORT
#endif

// does the C here mean that it exports the method as C? (since C# can interop with C but not c++???)
extern "C" DLLEXPORT void Sum(int number1, int number2, int& result);