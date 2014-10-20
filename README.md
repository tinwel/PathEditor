# PathEditor

## Synopsis:

The "path" list is stored as a string, so the traditional way of editing it is through a small, single-row text input field, like this:

![Screenshot of PathEditor](Screenshots/stock-edit-window.png)

Within the string is still a list.  This program edits it as a list, like this:

![Screenshot of PathEditor](Screenshots/screenshot.jpg)

## Capabilities:
* View/Edit the User Path as a list instead of a string.
* Add path components either by navigating or typing.
* Change the order of path items by moving them up or down in the list.
* Remove path components with a couple of clicks.

## Installation:
* Download or clone this repository using a link in the right sidebar.
* Open the solution file (PathEditor.sln) using Visual Studio.
  * (If you don't have Visual Studio, you can download from Microsoft.com the free version, currently Visual Studio Express 2013 for Desktop, which is the same version that was used to develop this program.)
* Change the build target from "Debug" to "Release" if desired.
* Select the Build menu, and Build Solution item.
* Find the program binary file in one of the following locations relative to the project, depending on which build target was selected:
  * PathEditor\bin\Debug\PathEditor.exe
  * PathEditor\bin\Release\PathEditor.exe
