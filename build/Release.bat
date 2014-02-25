@echo off

IF .%1 == . (
	@echo off
	set /p VERSION="Enter version number (eg. 3.2.1): " %=%
	@echo on
)
IF NOT .%1 == . (
	set VERSION=%1
)

msbuild Build.msbuild
set BUILD_STATUS=%ERRORLEVEL% 

if %BUILD_STATUS%==0 goto continuebuild 
if not %BUILD_STATUS%==0 goto failbuild 
 
:failbuild
exit /b 1 

:continuebuild

msbuild Package.msbuild
set BUILD_STATUS=%ERRORLEVEL% 

if %BUILD_STATUS%==0 goto end 
if not %BUILD_STATUS%==0 goto failpackage 
 
:failpackage
exit /b 1 

:end
exit /b 0 