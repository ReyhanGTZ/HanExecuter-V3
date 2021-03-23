; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "HanExecuterV3"
#define MyAppVersion "1.0"
#define MyAppPublisher "ReyhanGTZ"
#define MyAppURL "https://www.example.com/"
#define MyAppExeName "HanExecuter V3.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{23768BBB-3286-4C38-A8C0-F1BA18ECEE21}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=HanExecuterV3
SetupIconFile=C:\Users\Reyhan\Downloads\hnet.com-image.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\EasyExploits.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\EasyExploitsDLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\exploit-main.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\HanExecuter V3.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\HanExecuter V3.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\RobloxHacksAPI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\RobloxHacksDLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Reyhan\OneDrive\Dokumen\GitHub\HanExecuter-V3\HanExecuterV3\WeAreDevs_API.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

