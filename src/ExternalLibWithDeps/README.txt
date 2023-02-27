This example shows how to set up a library that has an external dependency (aravis), which itself has further external dependencies.

Aravis info:
- Project url: https://github.com/AravisProject/aravis
- API Ref: https://aravisproject.github.io/docs/aravis-0.8/

Some useful learnings:

I used msys2 to build all of the dependent dlls
	The command [pacman -S mingw-w64-x86_64-aravis-gst] was used to download packages from here:  https://packages.msys2.org/package/mingw-w64-x86_64-aravis-gst

Next step is to add aravis to the library. There are a few stages:
	1. Create a "dependencies" folder in the CPlusPlusLibrary project folder, with subfolders for aravis and any other dependencies (glib in this case)
	2. Each dependency gets a folder with 2 sub-folders:
		include
		lib
	3. I found a load of header files from the msys directory for each dependency, which I placed in the [include] directory for each:
		C:\msys64\mingw64\include\aravis-0.8
		C:\msys64\mingw64\include\glib-2.0
		C:\msys64\mingw64\lib\glib-2.0\include
		NOTE: I only had to modify a single header file (arvapi.h) where I replaced:
			This: #define ARV_API extern __attribute__ ((visibility ("default")))
			With This: #define ARV_API _declspec(dllimport)
			Although I'm not 100% sure why that was required
	4. I then took the pre-built dlls from msys bin (C:\msys64\mingw64\bin) and added them to the [lib] directory for each.
		Note: I wasn't sure what dlls I needed and thought I had all of them. At that point I was getting a dll not found exception, but really that was just that the dll was missing dependencies but without a useful error.
			  I built a console app that used aravis on its own, and only then did I get detailled error information about exactly which dlls were missing.
			  There is probably a better way to learn this information.
	5. We really want a .lib file for aravis, but msys didnt create one. I used this tool to generate the .lib file from the aravis dll: https://github.com/KHeresy/GenLibFromDll
	6. The aravis.lib file was placed into lib folder alongside the dll
	7. Now we need to link everything, there are two major steps:
		7a. Add the library dependency include folders to the include path in the c++ project settings (so that it can read the headers)
		7b. We then need to add the .lib file to the linker in the project settings. Note: the .lib only, none of the dlls, and only the aravis lib 
	8. The project should now build, but will fail at runtime
	9. We need to make sure the dlls that we depend on actually get copied to our output folder, since they contain the implementation. I added these two post-build events:
		xcopy /y /d  "$(ProjectDir)dependencies\Aravis\lib\*" "$(OutDir)"
		xcopy /y /d  "$(ProjectDir)dependencies\glib-2.0\lib\*" "$(OutDir)"
	10. The project should now build AND run without error :)


	