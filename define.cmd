@echo off
set outfile=Pseudo.exe
set buildfiles=TempFile.cs AdminProcess.cs ExtensionMethods.cs Pseudo.cs
set runelevated=-win32manifest:Pseudo.exe.manifest
set strongname=/keyfile:keyfile.snk
set appicon=-win32icon:onequbit.ico
set winexeoptions=-target:winexe %appicon% %strongname% %runelevated%
set consoleoptions=-target:exe %appicon% %strongname%
REM set consoleoptions=-target:winexe %appicon% %strongname%
set compileoptions=-out:%outfile% %consoleoptions%
