call "C:\Program Files\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"

echo Building 001.Anito.Data.2010.sln
echo.
devenv /build release "1Release\001.Anito.Data.2010.sln"
echo. 
echo Done Building 001.Anito.Data.2010.sln
echo.
pause