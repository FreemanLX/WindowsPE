@echo off
rem
rem Installing Powershell, NET Framework 4.5 
rem

set MOUNT = %1
set PACKAGE = %2
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-WMI.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-WMI_en-us.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-NetFX.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-NetFX_en-us.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-Scripting.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-Scripting_en-us.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-PowerShell.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-PowerShell_en-us.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-StorageWMI.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-StorageWMI_en-us.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\WinPE-DismCmdlets.cab"
Dism /Add-Package /Image:%MOUNT% /PackagePath:"%PACKAGE%\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment\amd64\WinPE_OCs\en-us\WinPE-DismCmdlets_en-us.cab"


rem
rem Enable Windows Explorer on Windows PE
rem

copy /y %WINVER%\explorer.exe %MOUNT%\Windows
copy /y %WINVER%\en-US\explorer.exe.mui %MOUNT%\Windows\en-US\

copy /y %WINVER%\System32\actxprxy.dll  %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\advapi32.dll  %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\actxprxy.dll  %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\bcrypt.dll    %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\bcryptprimitives.dll  %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\cfgmgr32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\combase.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\crypt32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\cscapi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\d3d11.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\DataExchange.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\dcomp.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\dui70.dll %MOUNT%\Windows\System32\ 
copy /y %WINVER%\System32\duser.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\dwmapi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\dxgi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\edputil.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\ExplorerFrame.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\gdi32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\imm32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\kernel.appcore.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\kernel32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\KernelBase.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\mpr.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\MrmCoreR.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\msasn1.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\msctf.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\msftedit.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\msvcrt.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\netutils.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\ntdll.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\ntlanman.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\ntshrui.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\ole32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\oleaut32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\powrprof.dll %MOUNT%\Windows\System32\ 
copy /y %WINVER%\System32\profapi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\propsys.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\rpcrt4.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\sechost.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\SHCore.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\shell32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\shlwapi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\srvcli.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\sspicli.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\StructuredQuery.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\thumbcache.dll %MOUNT%\Windows\System32\ 
copy /y %WINVER%\System32\twinapi.appcore.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\twinapi.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\UIRibbon.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\user32.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\userenv.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\uxtheme.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\windows.storage.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\WindowsCodecs.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\winmm.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\winmmbase.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\wkscli.dll %MOUNT%\Windows\System32\
copy /y %WINVER%\System32\xmllite.dll %MOUNT%\Windows\System32\ 
takeown /F %MOUNT%\Windows\System32\startnet.cmd
del /S /F /Q %MOUNT%\Windows\System32\startnet.cmd

