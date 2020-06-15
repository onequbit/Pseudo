@echo off
set outfile=Pseudo.exe
set buildfiles=Win32Dll.cs TempFile.cs AdminProcess.cs ExtensionMethods.cs Notifier.cs ConsoleAttached.cs Pseudo.cs
set runelevated=-win32manifest:Pseudo.exe.manifest
set strongname=/keyfile:keyfile.snk
set appicon=-win32icon:onequbit.ico
set winexeoptions=-target:winexe %appicon% %strongname% %runelevated%
REM set consoleoptions=-target:exe %appicon% %strongname%
set consoleoptions=-target:winexe %appicon% %strongname%
set compileoptions=-out:%outfile% %consoleoptions%
