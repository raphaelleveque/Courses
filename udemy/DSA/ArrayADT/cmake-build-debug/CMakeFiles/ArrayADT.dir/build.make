# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.20

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /Applications/CLion.app/Contents/bin/cmake/mac/bin/cmake

# The command to remove a file.
RM = /Applications/CLion.app/Contents/bin/cmake/mac/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/ArrayADT.dir/depend.make
# Include the progress variables for this target.
include CMakeFiles/ArrayADT.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/ArrayADT.dir/flags.make

CMakeFiles/ArrayADT.dir/main.cpp.o: CMakeFiles/ArrayADT.dir/flags.make
CMakeFiles/ArrayADT.dir/main.cpp.o: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/ArrayADT.dir/main.cpp.o"
	/opt/homebrew/bin/g++-12 $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/ArrayADT.dir/main.cpp.o -c /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/main.cpp

CMakeFiles/ArrayADT.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/ArrayADT.dir/main.cpp.i"
	/opt/homebrew/bin/g++-12 $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/main.cpp > CMakeFiles/ArrayADT.dir/main.cpp.i

CMakeFiles/ArrayADT.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/ArrayADT.dir/main.cpp.s"
	/opt/homebrew/bin/g++-12 $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/main.cpp -o CMakeFiles/ArrayADT.dir/main.cpp.s

# Object files for target ArrayADT
ArrayADT_OBJECTS = \
"CMakeFiles/ArrayADT.dir/main.cpp.o"

# External object files for target ArrayADT
ArrayADT_EXTERNAL_OBJECTS =

ArrayADT: CMakeFiles/ArrayADT.dir/main.cpp.o
ArrayADT: CMakeFiles/ArrayADT.dir/build.make
ArrayADT: CMakeFiles/ArrayADT.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable ArrayADT"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/ArrayADT.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/ArrayADT.dir/build: ArrayADT
.PHONY : CMakeFiles/ArrayADT.dir/build

CMakeFiles/ArrayADT.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/ArrayADT.dir/cmake_clean.cmake
.PHONY : CMakeFiles/ArrayADT.dir/clean

CMakeFiles/ArrayADT.dir/depend:
	cd /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug /Users/raphaelleveque/Desktop/cs/courses/udemy/DSA/ArrayADT/cmake-build-debug/CMakeFiles/ArrayADT.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/ArrayADT.dir/depend

