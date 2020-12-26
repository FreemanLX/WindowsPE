wpeinit
::mainCLSIDs
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}" /ve /t REG_SZ /d "Network Diagnostics Framework" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}" /v "AppID" /t REG_SZ /d "{F3D3AA8D-EF96-4470-848E-BD70B803047A}" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\System32\ndfapi.dll,-40001" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\Elevation" /v "Enabled" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\Elevation" /v "IconReference" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\System32\ndfapi.dll,-500" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\ndfapi.dll" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\ProgID" /ve /t REG_SZ /d "ndfapi.NDFAPI.1" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\TypeLib" /ve /t REG_SZ /d "{11DD5EA9-F8DB-4F6E-BF7C-6AADBA404A3D}" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{C529C7EF-A3AF-45F2-8A47-767B33AA5CC0}\Version" /ve /t REG_SZ /d "1.0" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{11dbb47c-a525-400b-9e80-a54615a090c0}" /ve /t REG_SZ /d "CLSID_ExecuteFolder" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{11dbb47c-a525-400b-9e80-a54615a090c0}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-30309" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{11dbb47c-a525-400b-9e80-a54615a090c0}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\SOFTWARE\CLASSES\CLSID\{11dbb47c-a525-400b-9e80-a54615a090c0}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020420-0000-0000-C000-000000000046}" /ve /t REG_SZ /d "PSDispatch" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020420-0000-0000-C000-000000000046}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020420-0000-0000-C000-000000000046}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\oleaut32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020424-0000-0000-C000-000000000046}" /ve /t REG_SZ /d "PSOAInterface" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020424-0000-0000-C000-000000000046}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{00020424-0000-0000-C000-000000000046}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\oleaut32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}" /v "AppID" /t REG_SZ /d "{00021401-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}" /v "DisableProcessIsolation" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}" /ve /t REG_SZ /d "Shortcut" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\Implemented Categories\{00000003-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\OverrideFileSystemProperties" /v "System.Kind" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\ProgID" /ve /t REG_SZ /d "lnkfile" /f
Reg.exe add "HKLM\software\classes\CLSID\{00021401-0000-0000-C000-000000000046}\shellex\MayChangeDefaultMenu" /f
Reg.exe add "HKLM\software\classes\CLSID\{03022430-ABC4-11D0-BDE2-00AA001A1953}" /ve /t REG_SZ /d "PSFactoryBuffer" /f
Reg.exe add "HKLM\software\classes\CLSID\{03022430-ABC4-11D0-BDE2-00AA001A1953}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{03022430-ABC4-11D0-BDE2-00AA001A1953}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\oleacc.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\windows.storage.dll,-50691" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /v "SortOrderIndex" /t REG_DWORD /d "84" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /v "System.PropList.DetailsPaneNullSelect" /t REG_SZ /d "prop:" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /v "System.PropList.DetailsPaneNullSelectTitle" /t REG_SZ /d "prop:" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}" /ve /t REG_SZ /d "UsersLibraries" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-1023" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2961178893" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "270880" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\shell\restorelibraries" /v "Description" /t REG_SZ /d "@shell32.dll,-34646" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\shell\restorelibraries" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-34645" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\shell\restorelibraries" /v "SeparatorAfter" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\shell\restorelibraries" /v "SeparatorBefore" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{031E4825-7B94-4DC3-B131-E946B44C8DD5}\shell\restorelibraries\command" /v "DelegateExecute" /t REG_SZ /d "{c51b83e5-9edd-4250-b45a-da672ee3c70e}" /f
Reg.exe add "HKLM\software\classes\CLSID\{0340F119-A598-4ED9-B0AC-6F6A12D3E755}" /ve /t REG_SZ /d "Property Store over folder final" /f
Reg.exe add "HKLM\software\classes\CLSID\{0340F119-A598-4ED9-B0AC-6F6A12D3E755}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{0340F119-A598-4ED9-B0AC-6F6A12D3E755}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\propsys.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\Windows.Storage.Search.dll,-30523" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}" /ve /t REG_SZ /d "CLSID_SearchFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\Windows.Storage.Search.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\Windows.Storage.Search.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{04731B67-D933-450A-90E6-4ACD2E9408FE}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-184" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{7d83ee9b-2244-4e70-b1f5-5393042af1e4}" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{088E3905-0323-4B02-9826-5D99428E115F}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{08D5BFBF-FBCA-4322-9F70-CA9F66F8ED6A}" /ve /t REG_SZ /d "CommonLayoutModifier" /f
Reg.exe add "HKLM\software\classes\CLSID\{08D5BFBF-FBCA-4322-9F70-CA9F66F8ED6A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{08D5BFBF-FBCA-4322-9F70-CA9F66F8ED6A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A30F902-8398-4EE8-86F7-4CFB589F04D1}" /ve /t REG_SZ /d "Sync root make available online verb" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A30F902-8398-4EE8-86F7-4CFB589F04D1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A30F902-8398-4EE8-86F7-4CFB589F04D1}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A556D98-CFEE-4D84-82A7-00377F939198}" /ve /t REG_SZ /d "Default Associations Profile Handler" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A556D98-CFEE-4D84-82A7-00377F939198}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{0A556D98-CFEE-4D84-82A7-00377F939198}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{0C9281F9-6DA1-4006-8729-DE6E6B61581C}" /v "AppID" /t REG_SZ /d "{362cc086-4d81-4824-bbb5-666d34b3197d}" /f
Reg.exe add "HKLM\software\classes\CLSID\{0C9281F9-6DA1-4006-8729-DE6E6B61581C}" /ve /t REG_SZ /d "Windows Push Notification Platform" /f
Reg.exe add "HKLM\software\classes\CLSID\{0CA2640D-5B9C-4C59-A5FB-2DA61A7437CF}" /ve /t REG_SZ /d "Sync root make available online verb" /f
Reg.exe add "HKLM\software\classes\CLSID\{0CA2640D-5B9C-4C59-A5FB-2DA61A7437CF}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{0CA2640D-5B9C-4C59-A5FB-2DA61A7437CF}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{0E5AAE11-A475-4C5B-AB00-C66DE400274E}" /ve /t REG_SZ /d "Shell File System Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{0E5AAE11-A475-4C5B-AB00-C66DE400274E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{0E5AAE11-A475-4C5B-AB00-C66DE400274E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\Windows.Storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{0E5AAE11-A475-4C5B-AB00-C66DE400274E}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "524288" /f
Reg.exe add "HKLM\software\classes\CLSID\{104846AB-42B1-4E38-A80D-136F78C3F258}" /ve /t REG_SZ /d "Browser Progress Aggregator" /f
Reg.exe add "HKLM\software\classes\CLSID\{104846AB-42B1-4E38-A80D-136F78C3F258}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{104846AB-42B1-4E38-A80D-136F78C3F258}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{11016101-E366-4D22-BC06-4ADA335C892B}" /ve /t REG_SZ /d "IE History and Feeds Shell Data Source for Windows Search" /f
Reg.exe add "HKLM\software\classes\CLSID\{11016101-E366-4D22-BC06-4ADA335C892B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{11016101-E366-4D22-BC06-4ADA335C892B}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\ieframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{11016101-E366-4D22-BC06-4ADA335C892B}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{11016101-E366-4D22-BC06-4ADA335C892B}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{13A4BBE8-6527-40CB-A996-1602829541EF}" /ve /t REG_SZ /d "Frame Automation Object" /f
Reg.exe add "HKLM\software\classes\CLSID\{13A4BBE8-6527-40CB-A996-1602829541EF}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{13A4BBE8-6527-40CB-A996-1602829541EF}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1B1CAD8C-2DAB-11D2-B604-00104B703EFD}" /ve /t REG_SZ /d "Microsoft WBEM (non)Standard Marshaling for IEnumWbemClassObject" /f
Reg.exe add "HKLM\software\classes\CLSID\{1B1CAD8C-2DAB-11D2-B604-00104B703EFD}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{1B1CAD8C-2DAB-11D2-B604-00104B703EFD}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12689" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-108" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{4BD8D571-6D19-48D3-BE97-422220080E43}" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{1CF1260C-4DD0-4EBB-811F-33C572699FDE}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{1EEB5B5A-06FB-4732-96B3-975C0194EB39}" /ve /t REG_SZ /d "Itemsview" /f
Reg.exe add "HKLM\software\classes\CLSID\{1EEB5B5A-06FB-4732-96B3-975C0194EB39}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{1EEB5B5A-06FB-4732-96B3-975C0194EB39}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}" /ve /t REG_SZ /d "User Pinned" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\Instance\InitPropertyBag" /v "RegisterAlias" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{9e3995ab-1f9c-4f13-b827-48b24b6c7174}" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4027580429" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F3427C8-5C10-4210-AA03-2EE45287D668}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "8" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F486A52-3CB1-48FD-8F50-B8DC300D9F9D}" /ve /t REG_SZ /d "Memory Mapped Cache Mgr" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F486A52-3CB1-48FD-8F50-B8DC300D9F9D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F486A52-3CB1-48FD-8F50-B8DC300D9F9D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\propsys.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F849CCE-2546-4B9F-B03E-4004781BDC40}" /ve /t REG_SZ /d "CLSID_ExplorerLauncher" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F849CCE-2546-4B9F-B03E-4004781BDC40}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{1F849CCE-2546-4B9F-B03E-4004781BDC40}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-22912" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-9217" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}" /ve /t REG_SZ /d "Network" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-25" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell" /ve /t REG_SZ /d "none" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "513" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell\find" /v "LegacyDisable" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell\find" /v "SuppressionPolicy" /t REG_DWORD /d "128" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell\find" /ve /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-29188" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell\find\command" /v "DelegateExecute" /t REG_SZ /d "{a015411a-f97d-4ef3-8425-8a38d022aebc}" /f
Reg.exe add "HKLM\software\classes\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\shell\find\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\Explorer.exe" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-22913" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\windows.storage.dll,-9216" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /v "System.Keywords" /t REG_SZ /d "@%%windir%%\system32\windows.storage.dll,-9012" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /v "System.PropList.DetailsPaneNullSelect" /t REG_SZ /d "prop:*System.Computer.DomainName;*System.Computer.Workgroup;*System.Computer.Processor;System.Computer.Memory" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /v "System.PropList.DetailsPaneNullSelectTitle" /t REG_SZ /d "prop:System.Computer.SimpleName;*System.Computer.Description" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /ve /t REG_SZ /d "This PC" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-109" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell" /ve /t REG_SZ /d "none" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1581568" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\find" /v "LegacyDisable" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\find" /v "SuppressionPolicy" /t REG_DWORD /d "128" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\find" /ve /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\windows.storage.dll,-8503" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\find\command" /v "DelegateExecute" /t REG_SZ /d "{a015411a-f97d-4ef3-8425-8a38d022aebc}" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\find\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\Explorer.exe" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\Manage" /v "HasLUAShield" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\Manage" /v "MUIVerb" /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\mycomput.dll,-400" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\Manage" /v "SuppressionPolicy" /t REG_DWORD /d "1073741884" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\Manage" /ve /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\mycomput.dll,-400" /f
Reg.exe add "HKLM\software\classes\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\shell\Manage\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\CompMgmtLauncher.exe" /f
Reg.exe add "HKLM\software\classes\CLSID\{2155FEE3-2419-4373-B102-6843707EB41F}" /ve /t REG_SZ /d "Local Icon Cache" /f
Reg.exe add "HKLM\software\classes\CLSID\{2155FEE3-2419-4373-B102-6843707EB41F}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{2155FEE3-2419-4373-B102-6843707EB41F}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\thumbcache.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-31361" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-32012" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}" /v "System.ControlPanel.Category" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}" /ve /t REG_SZ /d "All Control Panel Items" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-27" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\Shell" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2684354564" /f
Reg.exe add "HKLM\software\classes\CLSID\{21EC2020-3AEA-1069-A2DD-08002B30309D}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "4609" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\prnfldr.dll,-8062" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\prnfldr.dll,-8036" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}" /ve /t REG_SZ /d "Printers" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-26" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\prnfldr.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}\ShellFolder" /v "Attributes" /t REG_DWORD /d "536870916" /f
Reg.exe add "HKLM\software\classes\CLSID\{2227A280-3AEA-1069-A2DE-08002B30309D}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{23650F94-13B8-4F39-B2C3-817E6564A756}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{23650F94-13B8-4F39-B2C3-817E6564A756}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\windows.immersiveshell.serviceprovider.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12688" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-113" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{0ddd015d-b06c-45d5-8c4c-f59713854639}" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{24AD3AD4-A569-4530-98E1-AB02F9417AA8}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{25DEAD04-1EAC-4911-9E3A-AD0A4AB560FD}" /v "AppId" /t REG_SZ /d "{a2b77517-6d12-4c60-b0c6-725e971ec8fe}" /f
Reg.exe add "HKLM\software\classes\CLSID\{25DEAD04-1EAC-4911-9E3A-AD0A4AB560FD}" /ve /t REG_SZ /d "CLSID_TrayNotify" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-31361" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-4161" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "System.AppUserModel.ID" /t REG_SZ /d "Microsoft.Windows.ControlPanel" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "System.AppUserModel.RelaunchCommand" /t REG_SZ /d "%%SystemRoot%%\system32\control.exe" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "System.AppUserModel.RelaunchDisplayNameResource" /t REG_EXPAND_SZ /d "#%%SystemRoot%%\system32\shell32.dll,-4161" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /v "System.AppUserModel.RelaunchIconResource" /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-27" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}" /ve /t REG_SZ /d "Control Panel" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-27" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2684354564" /f
Reg.exe add "HKLM\software\classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "4609" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}" /v "DescriptionID" /t REG_DWORD /d "9" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}" /v "LocalizedString" /t REG_SZ /d "@x:\Windows\System32\dlnashext.dll,-4096" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}" /ve /t REG_SZ /d "DLNA Media Servers Data Source" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}\DefaultIcon" /ve /t REG_SZ /d "dlnashext.dll,-200" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\dlnashext.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2826960896" /f
Reg.exe add "HKLM\software\classes\CLSID\{289AF617-1CC3-42A6-926C-E6A863F0E3BA}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "8720" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}" /ve /t REG_SZ /d "XSL Template" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\msxml3.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\ProgID" /ve /t REG_SZ /d "Msxml2.XSLTemplate" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\TypeLib" /ve /t REG_SZ /d "{F5078F18-C551-11D3-89B9-0000F81FE221}" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\Version" /ve /t REG_SZ /d "3.0" /f
Reg.exe add "HKLM\software\classes\CLSID\{2933BF94-7B36-11D2-B20E-00C04F983E60}\VersionIndependentProgID" /ve /t REG_SZ /d "Msxml2.XSLTemplate" /f
Reg.exe add "HKLM\software\classes\CLSID\{2D3468C1-36A7-43B6-AC24-D3F02FD9607A}" /ve /t REG_SZ /d "A collection of IUnknown objects that can be enumerated" /f
Reg.exe add "HKLM\software\classes\CLSID\{2D3468C1-36A7-43B6-AC24-D3F02FD9607A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{2D3468C1-36A7-43B6-AC24-D3F02FD9607A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{2F6CE85C-F9EE-43CA-90C7-8A9BD53A2467}" /ve /t REG_SZ /d "FileHistoryDataSource" /f
Reg.exe add "HKLM\software\classes\CLSID\{2F6CE85C-F9EE-43CA-90C7-8A9BD53A2467}\DefaultIcon" /ve /t REG_SZ /d "FileHistory.exe,0" /f
Reg.exe add "HKLM\software\classes\CLSID\{2F6CE85C-F9EE-43CA-90C7-8A9BD53A2467}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{2F6CE85C-F9EE-43CA-90C7-8A9BD53A2467}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\fhshl.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{2F6CE85C-F9EE-43CA-90C7-8A9BD53A2467}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2685403136" /f
Reg.exe add "HKLM\software\classes\CLSID\{30D49246-D217-465F-B00B-AC9DDD652EB7}" /v "AppID" /t REG_SZ /d "{30d49246-d217-465f-b00b-ac9ddd652eb7}" /f
Reg.exe add "HKLM\software\classes\CLSID\{30D49246-D217-465F-B00B-AC9DDD652EB7}" /ve /t REG_SZ /d "Identity Store" /f
Reg.exe add "HKLM\software\classes\CLSID\{30D49246-D217-465F-B00B-AC9DDD652EB7}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{30D49246-D217-465F-B00B-AC9DDD652EB7}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\IDStore.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{31143611-AC65-4568-AE76-8A9DAD50EA88}" /v "AppID" /t REG_SZ /d "{0B789C73-D8DA-416D-B665-C1603676CEB1}" /f
Reg.exe add "HKLM\software\classes\CLSID\{31143611-AC65-4568-AE76-8A9DAD50EA88}" /ve /t REG_SZ /d "CLSID_NotificationController" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}" /v "NoPreviousVersions" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-117" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\shellex\ContextMenuHandlers\{A8E64375-B645-4314-9EFC-C085981786FA}" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\ShellFolder" /v "Attributes" /t REG_DWORD /d "537133056" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "48" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\ShellFolder" /v "RestrictedAttributes" /t REG_DWORD /d "50" /f
Reg.exe add "HKLM\software\classes\CLSID\{3134EF9C-6B18-4996-AD04-ED5912E00EB5}\ShellFolder" /v "WantsParseDisplayName" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{317D06E8-5F24-433D-BDF7-79CE68D8ABC2}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{317D06E8-5F24-433D-BDF7-79CE68D8ABC2}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windowscodecs.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{33C53A50-F456-4884-B049-85FD643ECFED}" /ve /t REG_SZ /d "TF_InputProcessorProfiles" /f
Reg.exe add "HKLM\software\classes\CLSID\{33C53A50-F456-4884-B049-85FD643ECFED}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{33C53A50-F456-4884-B049-85FD643ECFED}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\msctf.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\wpdshext.dll,-512" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\wpdshext.dll,-510" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}" /ve /t REG_SZ /d "Portable Devices" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\wpdshext.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2684354564" /f
Reg.exe add "HKLM\software\classes\CLSID\{35786D3C-B075-49B9-88DD-029876E11C01}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "16" /f
Reg.exe add "HKLM\software\classes\CLSID\{35CEC8A3-2BE6-11D2-8773-92E220524153}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{35CEC8A3-2BE6-11D2-8773-92E220524153}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\stobject.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-184" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{374DE290-123F-4565-9164-39C4925E467B}" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{374DE290-123F-4565-9164-39C4925E467B}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{38086A84-31E7-4C8E-BB0E-9758D634C7E1}" /ve /t REG_SZ /d "Notification Center Status" /f
Reg.exe add "HKLM\software\classes\CLSID\{38086A84-31E7-4C8E-BB0E-9758D634C7E1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{38086A84-31E7-4C8E-BB0E-9758D634C7E1}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\Windows.UI.Shell.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\windows.storage.dll,-37218" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}" /v "SortOrderIndex" /t REG_DWORD /d "4096" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}" /ve /t REG_SZ /d "Frequent Places Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll,-37219" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\ShellFolder" /v "Attributes" /t REG_DWORD /d "3892576260" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\ShellFolder" /v "CallForAttributes" /t REG_DWORD /d "1048576" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "8224" /f
Reg.exe add "HKLM\software\classes\CLSID\{3936E9E4-D92C-4EEE-A85A-BC16D5EA0819}\ShellFolder" /v "WantsParseDisplayName" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12688" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-113" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{33E28130-4E1E-4676-835A-98395C3BC3BB}" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{3ADD1653-EB32-4CB0-BBD7-DFA0ABB5ACCA}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{3CE74DE4-53D3-4D74-8B83-431B3828BA53}" /ve /t REG_SZ /d "TF_DisplayAttributeMgr" /f
Reg.exe add "HKLM\software\classes\CLSID\{3CE74DE4-53D3-4D74-8B83-431B3828BA53}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{3CE74DE4-53D3-4D74-8B83-431B3828BA53}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\msctf.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12689" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-108" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{a0c69a99-21c8-4671-8703-7934162fcf1d}" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{3DFDF296-DBEC-4FB4-81D1-6A3438BCF4DE}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{4234D49B-0245-4DF3-B780-3893943456E1}" /ve /t REG_SZ /d "Applications" /f
Reg.exe add "HKLM\software\classes\CLSID\{4234D49B-0245-4DF3-B780-3893943456E1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{4234D49B-0245-4DF3-B780-3893943456E1}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\TwinUI.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4234D49B-0245-4DF3-B780-3893943456E1}\ShellFolder" /v "Attributes" /t REG_DWORD /d "537919488" /f
Reg.exe add "HKLM\software\classes\CLSID\{4234D49B-0245-4DF3-B780-3893943456E1}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{42AEDC87-2188-41FD-B9A3-0C966FEABEC1}" /ve /t REG_SZ /d "MruPidlList" /f
Reg.exe add "HKLM\software\classes\CLSID\{42AEDC87-2188-41FD-B9A3-0C966FEABEC1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{42AEDC87-2188-41FD-B9A3-0C966FEABEC1}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-9113" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}" /v "SortOrderIndex" /t REG_DWORD /d "76" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}" /ve /t REG_SZ /d "Public Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\Instance\InitPropertyBag" /v "Attributes" /t REG_SZ /d "0x00000011" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\Instance\InitPropertyBag" /v "DescriptionID" /t REG_SZ /d "0x3" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{DFDF76A2-C82A-4D63-906A-5644AC457385}" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4036231437" /f
Reg.exe add "HKLM\software\classes\CLSID\{4336A54D-038B-4685-AB02-99BB52D3FB8B}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "8" /f
Reg.exe add "HKLM\software\classes\CLSID\{437FF9C0-A07F-4FA0-AF80-84B6C6440A16}" /ve /t REG_SZ /d "Command Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{437FF9C0-A07F-4FA0-AF80-84B6C6440A16}\Implemented Categories\{00021490-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{437FF9C0-A07F-4FA0-AF80-84B6C6440A16}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{437FF9C0-A07F-4FA0-AF80-84B6C6440A16}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{437FF9C0-A07F-4FA0-AF80-84B6C6440A16}\ShellFolder" /v "Attributes" /t REG_DWORD /d "1744830880" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}" /v "FullDetails" /t REG_SZ /d "prop:System.PropGroup.Description;System.Comment;System.DateCreated;System.TotalFileSize" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-22914" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-9227" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}" /v "SortOrderIndex" /t REG_DWORD /d "72" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll,-235" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\InProcServer32" /v "LoadWithoutCOM" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shellex\ContextMenuHandlers\Offline Files" /ve /t REG_SZ /d "{474C98EE-CF3D-41f5-80E3-4AAB0AB04301}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shellex\ContextMenuHandlers\{596AB062-B4D2-4215-9F74-E9109B0A8153}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shellex\PropertySheetHandlers\{44f3dab6-4392-4186-bb7b-6282ccb7a9f6}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shellex\PropertySheetHandlers\{596AB062-B4D2-4215-9F74-E9109B0A8153}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shellex\PropertySheetHandlers\{ef43ecfe-2ab9-4632-bf21-58909dd177f0}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4035969341" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\ShellFolder" /v "CallForAttributes" /t REG_DWORD /d "131136" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "524840" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\cmd" /v "Extended" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\cmd" /v "NoWorkingDirectory" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\cmd" /ve /t REG_SZ /d "@shell32.dll,-8506" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\cmd\command" /ve /t REG_SZ /d "cmd.exe /s /k pushd \"%%V\"" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\find" /v "LegacyDisable" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\find" /v "SuppressionPolicy" /t REG_DWORD /d "128" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\find\command" /v "DelegateExecute" /t REG_SZ /d "{a015411a-f97d-4ef3-8425-8a38d022aebc}" /f
Reg.exe add "HKLM\software\classes\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\shell\find\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\Explorer.exe" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F811-1D3A-11D0-891F-00AA004B2E24}" /ve /t REG_SZ /d "WBEM Locator" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F811-1D3A-11D0-891F-00AA004B2E24}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F811-1D3A-11D0-891F-00AA004B2E24}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\wbemprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F812-1D3A-11D0-891F-00AA004B2E24}" /ve /t REG_SZ /d "Microsoft WBEM WbemClassObject Marshalling proxy" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F812-1D3A-11D0-891F-00AA004B2E24}\Implemented Categories\{00000003-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F812-1D3A-11D0-891F-00AA004B2E24}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{4590F812-1D3A-11D0-891F-00AA004B2E24}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4661626C-9F41-40A9-B3F5-5580E80CB347}" /v "AppId" /t REG_SZ /d "{65E2E13A-7110-4912-9F03-9A42E253D8F6}" /f
Reg.exe add "HKLM\software\classes\CLSID\{4661626C-9F41-40A9-B3F5-5580E80CB347}" /ve /t REG_SZ /d "tiledatamodelsvc" /f
Reg.exe add "HKLM\software\classes\CLSID\{4A04656D-52AA-49DE-8A09-CB178760E748}" /ve /t REG_SZ /d "Recycle Bin Manager" /f
Reg.exe add "HKLM\software\classes\CLSID\{4A04656D-52AA-49DE-8A09-CB178760E748}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{4A04656D-52AA-49DE-8A09-CB178760E748}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4C1FC63A-695C-47E8-A339-1A194BE3D0B8}" /ve /t REG_SZ /d "UIAnimationManager" /f
Reg.exe add "HKLM\software\classes\CLSID\{4C1FC63A-695C-47E8-A339-1A194BE3D0B8}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{4C1FC63A-695C-47E8-A339-1A194BE3D0B8}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\UIAnimation.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4DF0C730-DF9D-4AE3-9153-AA6B82E9795A}" /ve /t REG_SZ /d "Known Folder Manager" /f
Reg.exe add "HKLM\software\classes\CLSID\{4DF0C730-DF9D-4AE3-9153-AA6B82E9795A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{4DF0C730-DF9D-4AE3-9153-AA6B82E9795A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{4E77131D-3629-431C-9818-C5679DC83E81}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{4E77131D-3629-431C-9818-C5679DC83E81}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\cscui.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{50EF4544-AC9F-4A8E-B21B-8A26180DB13F}" /ve /t REG_SZ /d "Local Thumbnail Cache" /f
Reg.exe add "HKLM\software\classes\CLSID\{50EF4544-AC9F-4A8E-B21B-8A26180DB13F}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{50EF4544-AC9F-4A8E-B21B-8A26180DB13F}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\thumbcache.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{529A9E6B-6587-4F23-AB9E-9C7D683E3C50}" /ve /t REG_SZ /d "TF_ThreadMgr" /f
Reg.exe add "HKLM\software\classes\CLSID\{529A9E6B-6587-4F23-AB9E-9C7D683E3C50}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{529A9E6B-6587-4F23-AB9E-9C7D683E3C50}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%Systemroot%%\System32\msctf.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-31361" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-4161" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /ve /t REG_SZ /d "Control Panel command object for Start menu and desktop" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-27" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}\ShellFolder" /v "Attributes" /t REG_DWORD /d "32" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "512" /f
Reg.exe add "HKLM\software\classes\CLSID\{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}\Shell\Open\Command" /v "DelegateExecute" /t REG_SZ /d "{06622D85-6856-4460-8DE1-A81921B41C4B}" /f
Reg.exe add "HKLM\software\classes\CLSID\{56AD4C5D-B908-4F85-8FF1-7940C29B3BCF}" /ve /t REG_SZ /d "Window Property Store" /f
Reg.exe add "HKLM\software\classes\CLSID\{56AD4C5D-B908-4F85-8FF1-7940C29B3BCF}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{56AD4C5D-B908-4F85-8FF1-7940C29B3BCF}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}" /ve /t REG_SZ /d "UsersFiles" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-123" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\Windows.Storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4035182893" /f
Reg.exe add "HKLM\software\classes\CLSID\{59031A47-3F72-44A7-89C5-5595FE6B30EE}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "5243433" /f
Reg.exe add "HKLM\software\classes\CLSID\{5AB7172C-9C11-405C-8DD5-AF20F3606282}" /ve /t REG_SZ /d "SharedOverlayHandler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{5AB7172C-9C11-405C-8DD5-AF20F3606282}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{5AB7172C-9C11-405C-8DD5-AF20F3606282}\InprocServer32" /ve /t REG_SZ /d "x:\Users\Liam\AppData\Local\Microsoft\OneDrive\17.3.6390.0509\amd64\FileSyncShell64.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B4DAE26-B807-11D0-9815-00C04FD91972}" /ve /t REG_SZ /d "Menu Band" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B4DAE26-B807-11D0-9815-00C04FD91972}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B4DAE26-B807-11D0-9815-00C04FD91972}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B53B2C2-46D6-433E-AB6E-B82EFEF22B6E}" /ve /t REG_SZ /d "ExplorerCommandEnumerator" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B53B2C2-46D6-433E-AB6E-B82EFEF22B6E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B53B2C2-46D6-433E-AB6E-B82EFEF22B6E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\windows.storage.dll,-51409" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}" /v "System.ItemNameDisplayWithoutExtension" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\Windows.Storage.dll,-51409" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}" /ve /t REG_SZ /d "This Device" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\Instance\InitPropertyBag" /v "AllowChildAliasRegistration" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\Instance\InitPropertyBag" /v "KnownFolderIdEnumeration" /t REG_SZ /d "{FDD39AD0-238F-46AF-ADB4-6C85480369C7};{374DE290-123F-4565-9164-39C4925E467B};{4BD8D571-6D19-48D3-BE97-422220080E43};{33E28130-4E1E-4676-835A-98395C3BC3BB};{C870044B-F49E-4126-A9C3-B52A1FF411E8};{18989B1D-99B5-455B-841C-AB7C74E4DDFC}" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{DFDF76A2-C82A-4D63-906A-5644AC457385}" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4035969285" /f
Reg.exe add "HKLM\software\classes\CLSID\{5B934B42-522B-4C34-BBFE-37A3EF7B9C90}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "5242920" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3800-BD81-11D0-A3A5-00C04FD706EC}" /ve /t REG_SZ /d "Background Task Scheduler" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3800-BD81-11D0-A3A5-00C04FD706EC}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3800-BD81-11D0-A3A5-00C04FD706EC}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3801-BD81-11D0-A3A5-00C04FD706EC}" /ve /t REG_SZ /d "Shared Task Scheduler" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3801-BD81-11D0-A3A5-00C04FD706EC}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{603D3801-BD81-11D0-A3A5-00C04FD706EC}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{61667EE4-8071-46E2-9016-3DB2D7BE9E28}" /ve /t REG_SZ /d "Connected Account Services" /f
Reg.exe add "HKLM\software\classes\CLSID\{61667EE4-8071-46E2-9016-3DB2D7BE9E28}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{61667EE4-8071-46E2-9016-3DB2D7BE9E28}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SettingSyncCore.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{62112AA1-EBE4-11CF-A5FB-0020AFE7292D}" /ve /t REG_SZ /d "Shell Automation Folder View" /f
Reg.exe add "HKLM\software\classes\CLSID\{62112AA1-EBE4-11CF-A5FB-0020AFE7292D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{62112AA1-EBE4-11CF-A5FB-0020AFE7292D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}" /v "AppID" /t REG_SZ /d "{E10F6C3A-F1AE-4ADC-AA9D-2FE65525666E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-22915" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-8964" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}" /v "SortOrderIndex" /t REG_DWORD /d "120" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}" /ve /t REG_SZ /d "Recycle Bin" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\DefaultIcon" /v "Empty" /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-55" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\DefaultIcon" /v "Full" /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-54" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-55" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shellex\PropertySheetHandlers\{645FF040-5081-101B-9F08-00AA002F954E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\ShellFolder" /v "Attributes" /t REG_BINARY /d "40010020" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "512" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty" /v "CommandStateHandler" /t REG_SZ /d "{c9298eef-69dd-4cdd-b153-bdbc38486781}" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty" /v "Description" /t REG_SZ /d "@shell32.dll,-31332" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty" /v "Icon" /t REG_SZ /d "shell32.dll,-254" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-10564" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty\command" /v "DelegateExecute" /t REG_SZ /d "{48527bb3-e8de-450b-8910-8c4099cb8624}" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\tabsets" /v "location" /t REG_DWORD /d "256" /f
Reg.exe add "HKLM\software\classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\tabsets" /v "selection" /t REG_DWORD /d "256" /f
Reg.exe add "HKLM\software\classes\CLSID\{64693913-1C21-4F30-A98F-4E52906D3B56}" /ve /t REG_SZ /d "CLSID_AppInstanceFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{64693913-1C21-4F30-A98F-4E52906D3B56}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{64693913-1C21-4F30-A98F-4E52906D3B56}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\twinui.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{64693913-1C21-4F30-A98F-4E52906D3B56}\ShellFolder" /v "Attributes" /t REG_DWORD /d "537919488" /f
Reg.exe add "HKLM\software\classes\CLSID\{64693913-1C21-4F30-A98F-4E52906D3B56}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{660B90C8-73A9-4B58-8CAE-355B7F55341B}" /ve /t REG_SZ /d "Start Menu Cache" /f
Reg.exe add "HKLM\software\classes\CLSID\{660B90C8-73A9-4B58-8CAE-355B7F55341B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{660B90C8-73A9-4B58-8CAE-355B7F55341B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{674B6698-EE92-11D0-AD71-00C04FD8FDFF}" /ve /t REG_SZ /d "Microsoft WBEM Call Context" /f
Reg.exe add "HKLM\software\classes\CLSID\{674B6698-EE92-11D0-AD71-00C04FD8FDFF}\Implemented Categories\{00000003-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{674B6698-EE92-11D0-AD71-00C04FD8FDFF}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{674B6698-EE92-11D0-AD71-00C04FD8FDFF}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}" /v "System.Home.PropList.Sort" /t REG_SZ /d "prop:System.Home.SortOrder;System.ItemNameDisplay" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll,-51380" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2685403136" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\shell\pintohome" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-51388" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\shell\pintohome\command" /v "DelegateExecute" /t REG_SZ /d "{b455f46e-e4af-4035-b0a4-cf18d2f6f28e}" /f
Reg.exe add "HKLM\software\classes\CLSID\{679F85CB-0220-4080-B29B-5540CC05AAB6}\shell\Windows.folderoptions" /v "ExplorerCommandHandler" /t REG_SZ /d "{83bb272f-7d5e-4b6e-9250-889893f0dac7}" /f
Reg.exe add "HKLM\software\classes\CLSID\{682159D9-C321-47CA-B3F1-30E36B2EC8B9}" /v "AppId" /t REG_SZ /d "{CDCBCFCA-3CDC-436f-A4E2-0E02075250C2}" /f
Reg.exe add "HKLM\software\classes\CLSID\{682159D9-C321-47CA-B3F1-30E36B2EC8B9}" /ve /t REG_SZ /d "CLSID_DesktopExplorerHost" /f
Reg.exe add "HKLM\software\classes\CLSID\{682159D9-C321-47CA-B3F1-30E36B2EC8B9}\LocalServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\explorer.exe /factory,{682159d9-c321-47ca-b3f1-30e36b2ec8b9}" /f
Reg.exe add "HKLM\software\classes\CLSID\{6B3B8D23-FA8D-40B9-8DBD-B950333E2C52}" /v "AppID" /t REG_SZ /d "{4839DDB7-58C2-48F5-8283-E1D1807D0D7D}" /f
Reg.exe add "HKLM\software\classes\CLSID\{6B3B8D23-FA8D-40B9-8DBD-B950333E2C52}" /ve /t REG_SZ /d "ShellServiceHost" /f
Reg.exe add "HKLM\software\classes\CLSID\{6F13DD2E-EBEE-4DD5-A72E-850B2087F5DD}" /ve /t REG_SZ /d "Microsoft Metadata Policy Layer" /f
Reg.exe add "HKLM\software\classes\CLSID\{6F13DD2E-EBEE-4DD5-A72E-850B2087F5DD}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{6F13DD2E-EBEE-4DD5-A72E-850B2087F5DD}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\PhotoMetadataHandler.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{75DFF2B7-6936-4C06-A8BB-676A7B00B24B}" /v "AppId" /t REG_SZ /d "{CDCBCFCA-3CDC-436f-A4E2-0E02075250C2}" /f
Reg.exe add "HKLM\software\classes\CLSID\{75DFF2B7-6936-4C06-A8BB-676A7B00B24B}" /v "SingleUse" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{75DFF2B7-6936-4C06-A8BB-676A7B00B24B}" /ve /t REG_SZ /d "CLSID_SeparateMultipleProcessExplorerHost" /f
Reg.exe add "HKLM\software\classes\CLSID\{75DFF2B7-6936-4C06-A8BB-676A7B00B24B}\LocalServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\explorer.exe /factory,{75dff2b7-6936-4c06-a8bb-676a7b00b24b}" /f
Reg.exe add "HKLM\software\classes\CLSID\{76765B11-3F95-4AF2-AC9D-EA55D8994F1A}" /ve /t REG_SZ /d "Property System Both Class Factory" /f
Reg.exe add "HKLM\software\classes\CLSID\{76765B11-3F95-4AF2-AC9D-EA55D8994F1A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{76765B11-3F95-4AF2-AC9D-EA55D8994F1A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\propsys.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{78103FB7-AED7-4066-8BCD-30BB27B02331}" /ve /t REG_SZ /d "Microsoft WBEM WMI Object Factory" /f
Reg.exe add "HKLM\software\classes\CLSID\{78103FB7-AED7-4066-8BCD-30BB27B02331}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{78103FB7-AED7-4066-8BCD-30BB27B02331}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{7C021C10-E914-4A53-BDC8-315CEBF32B49}" /v "AppId" /t REG_SZ /d "{AFC732E2-BA57-4B3E-A70A-71371F99B871}" /f
Reg.exe add "HKLM\software\classes\CLSID\{7C021C10-E914-4A53-BDC8-315CEBF32B49}" /ve /t REG_SZ /d "CLSID_TrayToastActivator" /f
Reg.exe add "HKLM\software\classes\CLSID\{7C857801-7381-11CF-884D-00AA004B2E24}" /ve /t REG_SZ /d "PSFactoryBuffer" /f
Reg.exe add "HKLM\software\classes\CLSID\{7C857801-7381-11CF-884D-00AA004B2E24}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{7C857801-7381-11CF-884D-00AA004B2E24}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\wbemsvc.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EB5FBE4-2100-49E6-8593-17E130122F91}" /ve /t REG_SZ /d "Fade Task" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EB5FBE4-2100-49E6-8593-17E130122F91}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EB5FBE4-2100-49E6-8593-17E130122F91}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EFC002A-071F-4CE7-B265-F4B4263D2FD2}" /ve /t REG_SZ /d "Local Thumbnail Cache" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EFC002A-071F-4CE7-B265-F4B4263D2FD2}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{7EFC002A-071F-4CE7-B265-F4B4263D2FD2}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\thumbcache.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}" /ve /t REG_SZ /d "Microsoft TipAutoCompleteClient Control" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%CommonProgramFiles%%\microsoft shared\ink\tiptsf.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}\ProgID" /ve /t REG_SZ /d "TipAutoCompleteClient.TipAutoCompleteClient.1" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}\Version" /ve /t REG_SZ /d "1.0" /f
Reg.exe add "HKLM\software\classes\CLSID\{807C1E6C-1D00-453F-B920-B61BB7CDD997}\VersionIndependentProgID" /ve /t REG_SZ /d "TipAutoCompleteClient.TipAutoCompleteClient" /f
Reg.exe add "HKLM\software\classes\CLSID\{82C588E7-E54B-408C-9F8C-6AF9ADF6F1E9}" /ve /t REG_SZ /d "FormatForDisplay Helper" /f
Reg.exe add "HKLM\software\classes\CLSID\{82C588E7-E54B-408C-9F8C-6AF9ADF6F1E9}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{82C588E7-E54B-408C-9F8C-6AF9ADF6F1E9}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}" /v "InfoTip" /t REG_SZ /d "@x:\Windows\System32\ieframe.dll,-881" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}" /v "LocalizedString" /t REG_SZ /d "@x:\Windows\System32\ieframe.dll,-5723" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}" /ve /t REG_SZ /d "Internet Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\DefaultIcon" /ve /t REG_SZ /d "x:\Windows\System32\ieframe.dll,-190" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell" /ve /t REG_SZ /d "OpenHomePage" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\Shellex\ContextMenuHandlers\ieframe" /ve /t REG_SZ /d "{871C5380-42A0-1069-A2EA-08002B30309D}" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\Shellex\MayChangeDefaultMenu" /ve /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\ShellFolder" /v "Attributes" /t REG_DWORD /d "36" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "131602" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\ShellFolder" /v "HideAsDeletePerUser" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\NoAddOns" /v "LegacyDisable" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\NoAddOns" /ve /t REG_SZ /d "Start Without Add-ons" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\NoAddOns\Command" /ve /t REG_SZ /d "\"x:\Program Files\Internet Explorer\iexplore.exe\" -extoff" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\OpenHomePage" /v "LegacyDisable" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\OpenHomePage" /ve /t REG_SZ /d "Open &Home Page" /f
Reg.exe add "HKLM\software\classes\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}\shell\OpenHomePage\Command" /ve /t REG_SZ /d "\"x:\Program Files\Internet Explorer\iexplore.exe\"" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}" /ve /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\mssvp.dll,-110" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\mssvp.dll,-504" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\mssvp.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538181632" /f
Reg.exe add "HKLM\software\classes\CLSID\{89D83576-6BD1-4C86-9454-BEB04E94C819}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{8BC3F05E-D86B-11D0-A075-00C04FB68820}" /v "AppId" /t REG_SZ /d "{8BC3F05E-D86B-11D0-A075-00C04FB68820}" /f
Reg.exe add "HKLM\software\classes\CLSID\{8BC3F05E-D86B-11D0-A075-00C04FB68820}" /v "LocalService" /t REG_SZ /d "winmgmt" /f
Reg.exe add "HKLM\software\classes\CLSID\{8BC3F05E-D86B-11D0-A075-00C04FB68820}" /ve /t REG_SZ /d "Windows Management and Instrumentation" /f
Reg.exe add "HKLM\software\classes\CLSID\{8D1C559D-84F0-4BB3-A7D5-56A7435A9BA6}" /ve /t REG_SZ /d "Microsoft WBEM WMI Object Factory" /f
Reg.exe add "HKLM\software\classes\CLSID\{8D1C559D-84F0-4BB3-A7D5-56A7435A9BA6}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{8D1C559D-84F0-4BB3-A7D5-56A7435A9BA6}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}" /ve /t REG_SZ /d "DXP" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\dxp.dll,0" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\dxp.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2685403168" /f
Reg.exe add "HKLM\software\classes\CLSID\{8FD8B88D-30E1-4F25-AC2B-553D3D65F0EA}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{90AA3A4E-1CBA-4233-B8BB-535773D48449}" /v "ImplementsVerbs" /t REG_SZ /d "taskbarpin;taskbarunpin" /f
Reg.exe add "HKLM\software\classes\CLSID\{90AA3A4E-1CBA-4233-B8BB-535773D48449}" /ve /t REG_SZ /d "Taskband Pin" /f
Reg.exe add "HKLM\software\classes\CLSID\{90AA3A4E-1CBA-4233-B8BB-535773D48449}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{90AA3A4E-1CBA-4233-B8BB-535773D48449}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}" /v "AppID" /t REG_SZ /d "{CC70FEAD-94B9-4F76-88CC-004BB068ACDF}" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}" /ve /t REG_SZ /d "Enhanced Storage Data Source" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\EhStorShell.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2818572320" /f
Reg.exe add "HKLM\software\classes\CLSID\{9113A02D-00A3-46B9-BC5F-9C04DADDD5D7}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{926749FA-2615-4987-8845-C33E65F2B957}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{926749FA-2615-4987-8845-C33E65F2B957}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\UIRibbon.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}" /ve /t REG_SZ /d "CLSID_SearchHome" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\searchfolder.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538181632" /f
Reg.exe add "HKLM\software\classes\CLSID\{9343812E-1C37-4A49-A12E-4B2D810D956B}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{934D4698-6A59-48F8-9F29-9FB30670320E}" /ve /t REG_SZ /d "Structured Query Helper Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{934D4698-6A59-48F8-9F29-9FB30670320E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{934D4698-6A59-48F8-9F29-9FB30670320E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\StructuredQuery.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{93A56381-E0CD-485A-B60E-67819E12F81B}" /ve /t REG_SZ /d "CLSID_CommonExplorerHost" /f
Reg.exe add "HKLM\software\classes\CLSID\{93A56381-E0CD-485A-B60E-67819E12F81B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{93A56381-E0CD-485A-B60E-67819E12F81B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}" /ve /t REG_SZ /d "CLSID_StartMenuLauncherProviderFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{98F275B4-4FFF-11E0-89E2-7B86DFD72085}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{9AC9FBE1-E0A2-4AD6-B4EE-E212013EA917}" /ve /t REG_SZ /d "ShellItem Shell Namespace helper" /f
Reg.exe add "HKLM\software\classes\CLSID\{9AC9FBE1-E0A2-4AD6-B4EE-E212013EA917}\Implemented Categories\{00000003-0000-0000-C000-000000000046}" /f
Reg.exe add "HKLM\software\classes\CLSID\{9AC9FBE1-E0A2-4AD6-B4EE-E212013EA917}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{9AC9FBE1-E0A2-4AD6-B4EE-E212013EA917}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{9BA05972-F6A8-11CF-A442-00A0C90A8F39}" /v "AppId" /t REG_SZ /d "{9BA05972-F6A8-11CF-A442-00A0C90A8F39}" /f
Reg.exe add "HKLM\software\classes\CLSID\{9BA05972-F6A8-11CF-A442-00A0C90A8F39}" /ve /t REG_SZ /d "ShellWindows" /f
Reg.exe add "HKLM\software\classes\CLSID\{9BA05972-F6A8-11CF-A442-00A0C90A8F39}\LocalServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\rundll32.exe shell32.dll,SHCreateLocalServerRunDll {9BA05972-F6A8-11CF-A442-00A0C90A8F39}" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}" /ve /t REG_SZ /d "CLSID_StartMenuCommandingProviderFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{A00EE528-EBD9-48B8-944A-8942113D46AC}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0396A93-DC06-4AEF-BEE9-95FFCCAEF20E}" /ve /t REG_SZ /d "SyncingOverlayHandler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0396A93-DC06-4AEF-BEE9-95FFCCAEF20E}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0396A93-DC06-4AEF-BEE9-95FFCCAEF20E}\InprocServer32" /ve /t REG_SZ /d "x:\Users\Liam\AppData\Local\Microsoft\OneDrive\17.3.6390.0509\amd64\FileSyncShell64.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12690" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-189" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{18989B1D-99B5-455B-841C-AB7C74E4DDFC}" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{A0953C92-50DC-43BF-BE83-3742FED03C9C}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{A2A9545D-A0C2-42B4-9708-A0B2BADD77C8}" /v "ImplementsVerbs" /t REG_SZ /d "startpin;startunpin" /f
Reg.exe add "HKLM\software\classes\CLSID\{A2A9545D-A0C2-42B4-9708-A0B2BADD77C8}" /ve /t REG_SZ /d "Start Menu Pin" /f
Reg.exe add "HKLM\software\classes\CLSID\{A2A9545D-A0C2-42B4-9708-A0B2BADD77C8}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{A2A9545D-A0C2-42B4-9708-A0B2BADD77C8}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A4B544A1-438D-4B41-9325-869523E2D6C7}" /ve /t REG_SZ /d "TF_CategoryMgr" /f
Reg.exe add "HKLM\software\classes\CLSID\{A4B544A1-438D-4B41-9325-869523E2D6C7}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{A4B544A1-438D-4B41-9325-869523E2D6C7}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\msctf.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A78ED123-AB77-406B-9962-2A5D9D2F7F30}" /ve /t REG_SZ /d "SharedSyncingOverlayHandler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{A78ED123-AB77-406B-9962-2A5D9D2F7F30}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{A78ED123-AB77-406B-9962-2A5D9D2F7F30}\InprocServer32" /ve /t REG_SZ /d "x:\Users\Liam\AppData\Local\Microsoft\OneDrive\17.3.6390.0509\amd64\FileSyncShell64.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-112" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{A8CDFF1C-4878-43BE-B5FD-F8091C1C60D0}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB0B37EC-56F6-4A0E-A8FD-7A8BF7C2DA96}" /ve /t REG_SZ /d "CLSID_ExplorerHostCreator" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB0B37EC-56F6-4A0E-A8FD-7A8BF7C2DA96}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB0B37EC-56F6-4A0E-A8FD-7A8BF7C2DA96}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB517586-73CF-489C-8D8C-5AE0EAD0613A}" /ve /t REG_SZ /d "Microsoft DocProp Custom Draw Percent Full Control" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB517586-73CF-489C-8D8C-5AE0EAD0613A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB517586-73CF-489C-8D8C-5AE0EAD0613A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB8902B4-09CA-4BB6-B78D-A8F59079A8D5}" /v "AppID" /t REG_SZ /d "{AB8902B4-09CA-4bb6-B78D-A8F59079A8D5}" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB8902B4-09CA-4BB6-B78D-A8F59079A8D5}" /ve /t REG_SZ /d "Thumbnail Cache Class Factory for Out of Proc Server" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB8902B4-09CA-4BB6-B78D-A8F59079A8D5}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{AB8902B4-09CA-4BB6-B78D-A8F59079A8D5}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\thumbcache.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{AD974AE2-E292-4083-A280-0342D68DAF55}" /ve /t REG_SZ /d "Updatable Item Set" /f
Reg.exe add "HKLM\software\classes\CLSID\{AD974AE2-E292-4083-A280-0342D68DAF55}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{AD974AE2-E292-4083-A280-0342D68DAF55}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{AE054212-3535-4430-83ED-D501AA6680E6}" /ve /t REG_SZ /d "Shell Name Space ListView" /f
Reg.exe add "HKLM\software\classes\CLSID\{AE054212-3535-4430-83ED-D501AA6680E6}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{AE054212-3535-4430-83ED-D501AA6680E6}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B0A8F3CF-4333-4BAB-8873-1CCB1CADA48B}" /ve /t REG_SZ /d "Drive Type Categorizer" /f
Reg.exe add "HKLM\software\classes\CLSID\{B0A8F3CF-4333-4BAB-8873-1CCB1CADA48B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{B0A8F3CF-4333-4BAB-8873-1CCB1CADA48B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}" /ve /t REG_SZ /d "delegate folder that appears in Computer" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\Instance\InitPropertyBag" /v "Attributes" /t REG_SZ /d "0x00000011" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\Instance\InitPropertyBag" /v "DescriptionID" /t REG_SZ /d "0x9" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{C5ABBF53-E17F-4121-8900-86626FC2C973}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\ShellFolder" /v "Attributes" /t REG_DWORD /d "1610612992" /f
Reg.exe add "HKLM\software\classes\CLSID\{B155BDF8-02F0-451E-9A26-AE317CFD7779}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "16" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-183" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-50688" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}" /v "SortOrderIndex" /t REG_DWORD /d "96" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}" /ve /t REG_SZ /d "Other Users Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-1013" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell" /ve /t REG_SZ /d "changehomegroupsettings viewhomegrouppassword starthomegrouptroubleshooter sharewithdevices" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2961441036" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\ShellFolder" /v "CallForAttributes" /t REG_DWORD /d "1048576" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "270880" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\changehomegroupsettings" /v "Description" /t REG_SZ /d "@shell32.dll,-50694" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\changehomegroupsettings" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-50693" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\changehomegroupsettings" /v "NeverDefault" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\changehomegroupsettings" /v "SeparatorBefore" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\changehomegroupsettings\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\control.exe /name Microsoft.HomeGroup" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\sharewithdevices" /v "Description" /t REG_SZ /d "@shell32.dll,-50700" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\sharewithdevices" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-50699" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\sharewithdevices" /v "NeverDefault" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\sharewithdevices" /v "SeparatorAfter" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\sharewithdevices\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\control.exe /name Microsoft.NetworkAndSharingCenter /page ShareMedia" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\starthomegrouptroubleshooter" /v "Description" /t REG_SZ /d "@shell32.dll,-50698" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\starthomegrouptroubleshooter" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-50697" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\starthomegrouptroubleshooter" /v "NeverDefault" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\starthomegrouptroubleshooter\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\msdt.exe -id HomegroupDiagnostic" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\viewhomegrouppassword" /v "CommandStateHandler" /t REG_SZ /d "{CCAEAA6D-3A50-488F-A664-5FACF424BC46}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\viewhomegrouppassword" /v "Description" /t REG_SZ /d "@shell32.dll,-50696" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\viewhomegrouppassword" /v "MUIVerb" /t REG_SZ /d "@shell32.dll,-50695" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\viewhomegrouppassword" /v "NeverDefault" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{B4FB3F98-C1EA-428D-A78A-D1F5659CBA93}\shell\viewhomegrouppassword\command" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\control.exe /name Microsoft.HomeGroup /page Passkey" /f
Reg.exe add "HKLM\software\classes\CLSID\{B52D54BB-4818-4EB9-AA80-F9EACD371DF8}" /v "AppID" /t REG_SZ /d "{9E175B9C-F52A-11D8-B9A5-505054503030}" /f
Reg.exe add "HKLM\software\classes\CLSID\{B52D54BB-4818-4EB9-AA80-F9EACD371DF8}" /ve /t REG_SZ /d "Windows Search Platform" /f
Reg.exe add "HKLM\software\classes\CLSID\{B5F8350B-0548-48B1-A6EE-88BD00B4A5E7}" /ve /t REG_SZ /d "MSAA AccPropServices" /f
Reg.exe add "HKLM\software\classes\CLSID\{B5F8350B-0548-48B1-A6EE-88BD00B4A5E7}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{B5F8350B-0548-48B1-A6EE-88BD00B4A5E7}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\oleacc.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B77B1CBF-E827-44A9-A33A-6CCFEEAA142A}" /ve /t REG_SZ /d "ShellItemArray Shell Namespace helper" /f
Reg.exe add "HKLM\software\classes\CLSID\{B77B1CBF-E827-44A9-A33A-6CCFEEAA142A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{B77B1CBF-E827-44A9-A33A-6CCFEEAA142A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B8967F85-58AE-4F46-9FB2-5D7904798F4B}" /ve /t REG_SZ /d "Property System" /f
Reg.exe add "HKLM\software\classes\CLSID\{B8967F85-58AE-4F46-9FB2-5D7904798F4B}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "both" /f
Reg.exe add "HKLM\software\classes\CLSID\{B8967F85-58AE-4F46-9FB2-5D7904798F4B}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\propsys.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{B9BC2A50-43C3-41AA-A086-5DB14E184BAE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{B9BC2A50-43C3-41AA-A086-5DB14E184BAE}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\InputSwitch.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{BBACC218-34EA-4666-9D7A-C78F2274A524}" /ve /t REG_SZ /d "ErrorOverlayHandler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{BBACC218-34EA-4666-9D7A-C78F2274A524}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{BBACC218-34EA-4666-9D7A-C78F2274A524}\InprocServer32" /ve /t REG_SZ /d "x:\Users\Liam\AppData\Local\Microsoft\OneDrive\17.3.6390.0509\amd64\FileSyncShell64.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}" /ve /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\mssvp.dll,-112" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\mssvp.dll,-505" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\mssvp.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538181632" /f
Reg.exe add "HKLM\software\classes\CLSID\{BD7A2E7B-21CB-41B2-A086-B309680C6B7E}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{BDE9EE7C-329F-4FCF-BA7A-F8C6E9B4579D}" /ve /t REG_SZ /d "DUI Shell View Frame" /f
Reg.exe add "HKLM\software\classes\CLSID\{BDE9EE7C-329F-4FCF-BA7A-F8C6E9B4579D}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{BDE9EE7C-329F-4FCF-BA7A-F8C6E9B4579D}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{C206F324-BB45-4765-93FF-3BCA7306FF2E}" /ve /t REG_SZ /d "CommonLayoutDefinition" /f
Reg.exe add "HKLM\software\classes\CLSID\{C206F324-BB45-4765-93FF-3BCA7306FF2E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{C206F324-BB45-4765-93FF-3BCA7306FF2E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{C2CF3110-460E-4FC1-B9D0-8A1C0C9CC4BD}" /v "AppId" /t REG_SZ /d "{8B30085D-A3E3-44e3-AE7F-B03A1340EBED}" /f
Reg.exe add "HKLM\software\classes\CLSID\{C2CF3110-460E-4FC1-B9D0-8A1C0C9CC4BD}" /ve /t REG_SZ /d "Desktop Wallpaper" /f
Reg.exe add "HKLM\software\classes\CLSID\{C2F03A33-21F5-47FA-B4BB-156362A2F239}" /v "AppID" /t REG_SZ /d "{316cded5-e4ae-4b15-9113-7055d84dcc97}" /f
Reg.exe add "HKLM\software\classes\CLSID\{C2F03A33-21F5-47FA-B4BB-156362A2F239}" /ve /t REG_SZ /d "Immersive Shell" /f
Reg.exe add "HKLM\software\classes\CLSID\{C71C41F1-DDAD-42DC-A8FC-F5BFC61DF957}" /ve /t REG_SZ /d "Immersive Shell Builder" /f
Reg.exe add "HKLM\software\classes\CLSID\{C71C41F1-DDAD-42DC-A8FC-F5BFC61DF957}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{C71C41F1-DDAD-42DC-A8FC-F5BFC61DF957}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\TwinUI.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{C90250F3-4D7D-4991-9B69-A5C5BC1C2AE6}" /ve /t REG_SZ /d "PSFactoryBuffer" /f
Reg.exe add "HKLM\software\classes\CLSID\{C90250F3-4D7D-4991-9B69-A5C5BC1C2AE6}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{C90250F3-4D7D-4991-9B69-A5C5BC1C2AE6}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\ActXPrxy.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-112" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{f42ee2d3-909f-4907-8871-4c22fc0bf756}" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{D3162B92-9365-467A-956B-92703ACA08AF}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{D58960BA-2EF3-4910-9E34-C911B1710180}" /ve /t REG_SZ /d "ShellTravelLog" /f
Reg.exe add "HKLM\software\classes\CLSID\{D58960BA-2EF3-4910-9E34-C911B1710180}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{D58960BA-2EF3-4910-9E34-C911B1710180}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{d63a5850-8f16-11cf-9f47-00aa00bf345c}" /ve /t REG_SZ /d "WBEM Framework Instance Provider" /f
Reg.exe add "HKLM\software\classes\CLSID\{d63a5850-8f16-11cf-9f47-00aa00bf345c}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{d63a5850-8f16-11cf-9f47-00aa00bf345c}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\cimwin32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{D68AF00A-29CB-43FA-8504-CE99A996D9EA}" /ve /t REG_SZ /d "Microsoft WBEM (non)Standard Marshaling for IWbemServices" /f
Reg.exe add "HKLM\software\classes\CLSID\{D68AF00A-29CB-43FA-8504-CE99A996D9EA}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{D68AF00A-29CB-43FA-8504-CE99A996D9EA}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\fastprox.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{D9144DCD-E998-4ECA-AB6A-DCD83CCBA16D}" /v "AppID" /t REG_SZ /d "{CC70FEAD-94B9-4F76-88CC-004BB068ACDF}" /f
Reg.exe add "HKLM\software\classes\CLSID\{D9144DCD-E998-4ECA-AB6A-DCD83CCBA16D}" /ve /t REG_SZ /d "Enhanced Storage Icon Overlay Handler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{D9144DCD-E998-4ECA-AB6A-DCD83CCBA16D}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{D9144DCD-E998-4ECA-AB6A-DCD83CCBA16D}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\EhStorShell.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{D92BD3B9-99A0-4334-A497-11BCB093E9D2}" /ve /t REG_SZ /d "ShellWindows Class Factory" /f
Reg.exe add "HKLM\software\classes\CLSID\{D92BD3B9-99A0-4334-A497-11BCB093E9D2}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{D92BD3B9-99A0-4334-A497-11BCB093E9D2}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}" /ve /t REG_SZ /d "CLSID_StartMenuProviderFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{DAF95313-E44D-46AF-BE1B-CBACEA2C3065}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{DD313E04-FEFF-11D1-8ECD-0000F87A470C}" /ve /t REG_SZ /d "User Assist" /f
Reg.exe add "HKLM\software\classes\CLSID\{DD313E04-FEFF-11D1-8ECD-0000F87A470C}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{DD313E04-FEFF-11D1-8ECD-0000F87A470C}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{DD522ACC-F821-461A-A407-50B198B896DC}" /v "AppID" /t REG_SZ /d "{B1B9CBB2-B198-47E2-8260-9FD629A2B2EC}" /f
Reg.exe add "HKLM\software\classes\CLSID\{DD522ACC-F821-461A-A407-50B198B896DC}" /ve /t REG_SZ /d "HardwareDeviceNotif" /f
Reg.exe add "HKLM\software\classes\CLSID\{DE77BA04-3C92-4D11-A1A5-42352A53E0E3}" /ve /t REG_SZ /d "Home Group Member Status" /f
Reg.exe add "HKLM\software\classes\CLSID\{DE77BA04-3C92-4D11-A1A5-42352A53E0E3}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{DE77BA04-3C92-4D11-A1A5-42352A53E0E3}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\provsvc.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}" /ve /t REG_SZ /d "delegate folder that appears in Users Files Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\Windows.Storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{5E6C858F-0E22-4760-9AFE-EA3317B67173}" /f
Reg.exe add "HKLM\software\classes\CLSID\{DFFACDC5-679F-4156-8947-C5C76BC0B67F}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1080" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}" /ve /t REG_SZ /d "CLSID_StartMenuPathCompleteProviderFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll,-323" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\SearchFolder.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538443776" /f
Reg.exe add "HKLM\software\classes\CLSID\{E345F35F-9397-435C-8F95-4E922C26259E}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{E6442437-6C68-4F52-94DD-2CFED267EFB9}" /v "AppId" /t REG_SZ /d "{E6442437-6C68-4f52-94DD-2CFED267EFB9}" /f
Reg.exe add "HKLM\software\classes\CLSID\{E6442437-6C68-4F52-94DD-2CFED267EFB9}" /ve /t REG_SZ /d "CLSID_TrayDesktopBand" /f
Reg.exe add "HKLM\software\classes\CLSID\{E7D35CFA-348B-485E-B524-252725D697CA}" /ve /t REG_SZ /d "PSFactoryBuffer" /f
Reg.exe add "HKLM\software\classes\CLSID\{E7D35CFA-348B-485E-B524-252725D697CA}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{E7D35CFA-348B-485E-B524-252725D697CA}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\wbemsvc.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{EAC8A024-21E2-4523-AD73-A71A0AA2F56A}" /ve /t REG_SZ /d "WbemQuery" /f
Reg.exe add "HKLM\software\classes\CLSID\{EAC8A024-21E2-4523-AD73-A71A0AA2F56A}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{EAC8A024-21E2-4523-AD73-A71A0AA2F56A}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\wbem\wmiutils.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4D-521C-11D0-B792-00A0C90312E1}" /ve /t REG_SZ /d "Shell Rebar BandSite" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4D-521C-11D0-B792-00A0C90312E1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4D-521C-11D0-B792-00A0C90312E1}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4E-521C-11D0-B792-00A0C90312E1}" /ve /t REG_SZ /d "Shell Band Site Menu" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4E-521C-11D0-B792-00A0C90312E1}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{ECD4FC4E-521C-11D0-B792-00A0C90312E1}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\explorerframe.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "InfoTip" /t REG_SZ /d "Play and Manage Games." /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-30579" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "System.AppUserModel.ID" /t REG_SZ /d "Microsoft.Windows.GamesExplorer" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "System.AppUserModel.RelaunchCommand" /t REG_SZ /d "%%SystemRoot%%\explorer.exe shell:::{ED228FDF-9EA8-4870-83b1-96b02CFE0D52}" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "System.AppUserModel.RelaunchDisplayNameResource" /t REG_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-30579" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /v "System.AppUserModel.RelaunchIconResource" /t REG_SZ /d "%%SystemRoot%%\system32\imageres.dll,-14" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}" /ve /t REG_SZ /d "Games Explorer" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\DefaultIcon" /ve /t REG_SZ /d "x:\Windows\System32\imageres.dll,-14" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\InprocServer32" /ve /t REG_SZ /d "x:\Windows\System32\gameux.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\Programmable" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\ShellFolder" /v "Attributes" /t REG_DWORD /d "537919792" /f
Reg.exe add "HKLM\software\classes\CLSID\{ED228FDF-9EA8-4870-83B1-96B02CFE0D52}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{EDC978D6-4D53-4B2F-A265-5805674BE568}" /ve /t REG_SZ /d "StreamBackedFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{EDC978D6-4D53-4B2F-A265-5805674BE568}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{EDC978D6-4D53-4B2F-A265-5805674BE568}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{EDC978D6-4D53-4B2F-A265-5805674BE568}\ShellFolder" /v "Attributes" /t REG_DWORD /d "537919488" /f
Reg.exe add "HKLM\software\classes\CLSID\{EDC978D6-4D53-4B2F-A265-5805674BE568}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /v "ControlPanel" /t REG_SZ /d "/name Microsoft.NetworkAndSharingCenter" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /v "InfoTip" /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\NetworkExplorer.dll,-2" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /v "LocalizedString" /t REG_EXPAND_SZ /d "@%%systemroot%%\system32\NetworkExplorer.dll,-1" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /v "SortOrderIndex" /t REG_DWORD /d "88" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /ve /t REG_SZ /d "Computers and Devices" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\imageres.dll,-25" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\InProcServer32" /v "LoadWithoutCOM" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\NetworkExplorer.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2953052260" /f
Reg.exe add "HKLM\software\classes\CLSID\{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1057344" /f
Reg.exe add "HKLM\software\classes\CLSID\{F0AE1542-F497-484B-A175-A20DB09144BA}" /ve /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{F0AE1542-F497-484B-A175-A20DB09144BA}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{F0AE1542-F497-484B-A175-A20DB09144BA}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F241C880-6982-4CE5-8CF7-7085BA96DA5A}" /ve /t REG_SZ /d "UpToDateOverlayHandler Class" /f
Reg.exe add "HKLM\software\classes\CLSID\{F241C880-6982-4CE5-8CF7-7085BA96DA5A}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{F241C880-6982-4CE5-8CF7-7085BA96DA5A}\InprocServer32" /ve /t REG_SZ /d "x:\Users\Liam\AppData\Local\Microsoft\OneDrive\17.3.6390.0509\amd64\FileSyncShell64.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F324E4F9-8496-40B2-A1FF-9617C1C9AFFE}" /ve /t REG_SZ /d "Sync root manager" /f
Reg.exe add "HKLM\software\classes\CLSID\{F324E4F9-8496-40B2-A1FF-9617C1C9AFFE}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{F324E4F9-8496-40B2-A1FF-9617C1C9AFFE}\InProcServer32" /ve /t REG_SZ /d "x:\Windows\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3364BA0-65B9-11CE-A9BA-00AA004AE837}" /ve /t REG_SZ /d "Shell File System Folder" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3364BA0-65B9-11CE-A9BA-00AA004AE837}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3364BA0-65B9-11CE-A9BA-00AA004AE837}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3364BA0-65B9-11CE-A9BA-00AA004AE837}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1572864" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}" /ve /t REG_SZ /d "Sticky Notes Namespace Extension for Windows Desktop Search" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\SNTSearch.dll,-100" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\InprocServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\InprocServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\SNTSearch.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\ProgID" /ve /t REG_SZ /d "StickyNote.ShellFolder.1" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\ShellFolder" /v "Attributes" /t REG_DWORD /d "538181632" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\software\classes\CLSID\{F3F5824C-AD58-4728-AF59-A1EBE3392799}\VersionIndependentProgID" /ve /t REG_SZ /d "Search.ShellFolder" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5A8B627-4D46-4D65-92F3-73626AE31971}" /ve /t REG_SZ /d "Explorer command store" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5A8B627-4D46-4D65-92F3-73626AE31971}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5A8B627-4D46-4D65-92F3-73626AE31971}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\windows.storage.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}" /ve /t REG_SZ /d "Removable Drives" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Apartment" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\Instance" /v "CLSID" /t REG_SZ /d "{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\Instance\InitPropertyBag" /v "HideNonRemovableDrives" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\Instance\InitPropertyBag" /v "UseRemovableDrivesRegPath" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\ShellFolder" /v "Attributes" /t REG_DWORD /d "2952790016" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "1040" /f
Reg.exe add "HKLM\software\classes\CLSID\{F5FB2C77-0E2F-4A16-A381-3E560C68BC83}\ShellFolder" /v "WantsParseDisplayName" /t REG_SZ /d "" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}" /ve /t REG_SZ /d "Free Threaded XML DOM Document" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\System32\msxml3.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\ProgID" /ve /t REG_SZ /d "Msxml2.FreeThreadedDOMDocument" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\TypeLib" /ve /t REG_SZ /d "{F5078F18-C551-11D3-89B9-0000F81FE221}" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\Version" /ve /t REG_SZ /d "3.0" /f
Reg.exe add "HKLM\software\classes\CLSID\{F6D90F12-9C73-11D3-B32E-00C04F990BB4}\VersionIndependentProgID" /ve /t REG_SZ /d "Msxml2.FreeThreadedDOMDocument" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}" /v "DescriptionID" /t REG_DWORD /d "3" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}" /v "Infotip" /t REG_EXPAND_SZ /d "@%%SystemRoot%%\system32\shell32.dll,-12690" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\DefaultIcon" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\imageres.dll,-189" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%systemroot%%\system32\shell32.dll" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\Instance" /v "CLSID" /t REG_SZ /d "{0E5AAE11-A475-4c5b-AB00-C66DE400274E}" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\Instance\InitPropertyBag" /v "Attributes" /t REG_DWORD /d "17" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\Instance\InitPropertyBag" /v "TargetKnownFolder" /t REG_SZ /d "{35286a68-3c57-41a1-bbb1-0eae73d76c95}" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\ShellFolder" /v "Attributes" /t REG_DWORD /d "4034920525" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\ShellFolder" /v "FolderValueFlags" /t REG_DWORD /d "41" /f
Reg.exe add "HKLM\software\classes\CLSID\{F86FA3AB-70D2-4FC7-9C99-FCBF05467F3A}\ShellFolder" /v "SortOrderIndex" /t REG_DWORD /d "0" /f

:DragDrop
Reg.exe add "HKLM\software\Microsoft\Ole\Extensions" /v "DragDropExtension" /t REG_SZ /d "{9FC8E510-A27C-4B3B-B9A3-BF65F00256A8}" /f
Reg.exe add "HKLM\software\Classes\CLSID\{9FC8E510-A27C-4B3B-B9A3-BF65F00256A8}\InProcServer32" /v "ThreadingModel" /t REG_SZ /d "Both" /f
Reg.exe add "HKLM\software\Classes\CLSID\{9FC8E510-A27C-4B3B-B9A3-BF65F00256A8}\InProcServer32" /ve /t REG_EXPAND_SZ /d "%%SystemRoot%%\system32\dataexchange.dll" /f
