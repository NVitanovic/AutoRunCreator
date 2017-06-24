// AutoRun.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "AutoRun.h"

#define MAX_LOADSTRING 1024

HINSTANCE hInst;                               
WCHAR * action;                  
WCHAR * parameters;            
WCHAR * file;
WCHAR * workDirectory;
WCHAR * visibility;

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
					 _In_opt_ HINSTANCE hPrevInstance,
					 _In_ LPWSTR    lpCmdLine,
					 _In_ int       nCmdShow)
{

	//reserve the memory
	action = new WCHAR[MAX_LOADSTRING];
	parameters = new WCHAR[MAX_LOADSTRING];
	file = new WCHAR[MAX_LOADSTRING];
	workDirectory = new WCHAR[MAX_LOADSTRING];
	visibility = new WCHAR[MAX_LOADSTRING];

	//set the memory to 0s
	ZeroMemory(action, sizeof(WCHAR)*MAX_LOADSTRING);
	ZeroMemory(parameters, sizeof(WCHAR)*MAX_LOADSTRING);
	ZeroMemory(file, sizeof(WCHAR)*MAX_LOADSTRING);
	ZeroMemory(workDirectory, sizeof(WCHAR)*MAX_LOADSTRING);
	ZeroMemory(visibility, sizeof(WCHAR)*MAX_LOADSTRING);

	//load the values from the resources
	LoadStringW(hInstance, S_ACTION, action, MAX_LOADSTRING);
	LoadStringW(hInstance, S_PARAMETERS, parameters, MAX_LOADSTRING);
	LoadStringW(hInstance, S_FILE, file, MAX_LOADSTRING);
	LoadStringW(hInstance, S_WORKINGDIR, workDirectory, MAX_LOADSTRING);
	LoadStringW(hInstance, S_VISIBILITY, visibility, MAX_LOADSTRING);
	
	//If values are empty set them as NULL
	if (action == NULL || wcslen(action) == 0 || (wcslen(action) == 1 && wcscmp(action, L" ") == 0)) //empty data
	{
		delete action;
		action = NULL;
	}
	if (parameters == NULL || wcslen(parameters) == 0 || (wcslen(parameters) == 1 && wcscmp(parameters, L" ") == 0)) //empty data
	{
		delete parameters;
		parameters = NULL;
	}
	if (file == NULL || wcslen(file) == 0 || (wcslen(file) == 1 && wcscmp(file, L" "))) //empty data
	{
		delete file;
		file = NULL;
	}
	if (workDirectory == NULL || wcslen(workDirectory) == 0 || (wcslen(workDirectory) == 1 && wcscmp(workDirectory, L" ") == 0)) //empty data
	{
		delete workDirectory;
		workDirectory = NULL;
	}

	//convert the string to integer
	int visibilityMode = _wtoi(visibility);
	
	//run the shell execution
	ShellExecute(NULL, action, file, parameters, workDirectory, visibilityMode);

	delete action, parameters, file, workDirectory, visibility;

	return 0;
}