# Minimalistic Shell for Windows PE
# Version 0.2_alpha
Making scripts and packages to build Windows PE (bat and C#) (it will be integrated on IntegrateOS later)\

Hardware requirements:
- 512 MB RAM (for the iso).
- 1 single core of the processor.

Installation:
1) Download Windows ADK and Windows PE from microsoft.com\
   https://learn.microsoft.com/en-us/windows-hardware/manufacture/desktop/winpe-intro?view=windows-11
   Personally I use Windows 10 ADK 2004 because it supports the X86 architecture.  

2) Create Windows PE and mount.\
   After installation, start <b>Deployment and Imaging Tools Environment</b> and run:

   ```
   copype <arch> <workingDirectory> 
   ```

   For example:
   ```
   copype x86 C:\winpe_x86
   ```

   After creating the files, you will have to mount:
   ```
   dism /mount-image /imagefile:<workingDirectory\media\sources\boot.wim> /index:1 /mountdir:<workingDirectory\mount>
   ```

   For example:
   ```
   dism /mount-image /imagefile:C:\winpe_x86\media\sources\boot.wim /index:1 /mountdir:C:\winpe_x86\mount
   ```

   Because the project is written on C# and C++ it needs to have the NET 4.5:

    - Go to the Windows PE main root folder from Program Files. For example:

      ```
      C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment
      ```
    - Then select the architecture you ve chosen before. In my case is x86, and click on the WinPE_OCs folder, you will see bunch of packages meant for Windows PE.

    - Use dism to add the NET 4.5 package on the mounted image:
   
      ```
      dism /image:<workingDirectory\mount> /add-package /packagepath:WinPE-NetFx.cab
      ```
   
   Check if the mounted image has the following files on the System32, if not copy directly from System 32
   ```
   kernel32.dll
   user32.dll
   comdlg32.dll
   ole32.dll
   oleaut32.dll
   netapi32.dll
   ```

3) Create winpeshl.ini file on the <b>System32 folder from the mounted image</b> and copy <b>windowspe.exe</b> to Windows folder and <b>shellcore.dll</b> to System32 folder. \
   And for example when creating the winpeshl.ini the file should look like this:
   
   ```
   [LaunchApp]
   AppPath = %SYSTEMDRIVE%\Windows\windowspe.exe
   ```
   
4) Unmount and create the iso.\
   To unmount the mounted image and save it you will have to write the following command:
   ```
   dism /unmount-image /mountdir:<workingDirectory\mount> /commit
   ```
   BE CAREFUL! It will not unmount when a process is opened on the mounted image path so is better to check if everything is closed related with it.
   To create the iso file write the following command:
   ```
   makewinpemedia /iso <workingDirectory> <isofile> 
   ```
   

Because is a minimalistic shell, it doesn't contain anything really special, only a start menu, file explorer, SMB file sharing, firewall and some settings in GUI.

Being also on the alpha part, the functionality is not yet completed, as some parts are missing.

Below you will see some screenshots

![image](https://user-images.githubusercontent.com/56113049/200154861-2bfc4f93-12bf-4217-920a-e27b39fd0aab.png)

![image](https://user-images.githubusercontent.com/56113049/200154879-33723330-9f88-4e0d-86b7-39b71a48e108.png)

![image](https://user-images.githubusercontent.com/56113049/200154891-77eaf8dc-3de1-4808-a213-719a84233463.png)

![image](https://user-images.githubusercontent.com/56113049/200154906-0281e827-10d0-499c-a0a2-879698b2933a.png)

![image](https://user-images.githubusercontent.com/56113049/200154930-55546655-3eed-4ff6-aa2e-0eb48c74b14d.png)

**What's next**
Well when I have my free time, I still need to add functionalities on Firewall (add / modify / delete rules) right now we can only view, fix bugs with SMB Share regarding the partition part, completing the functionality of the multiple process parts (replace ctrl + alt), completing the functionality of the file explorer and add the file copy GUI like on Windows. 
