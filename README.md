# Yandex clicker for minecraft (Was supposed to be an autoclicker)
### To reduce the project weight, the following libraries were removed. (You can install them in Project -> Manage NuGet Packages):
- Castle.Core.5.0.0
- Microsoft.Bcl.AsyncInterfaces.6.0.0
- Spectre.Console.0.50.0
- System.Buffers.4.6.1
- System.Configuration.ConfigurationManager.6.0.0
- System.Memory.4.6.3
- System.Numerics.Vectors.4.6.1
- System.Runtime.CompilerServices.Unsafe.6.1.2
- System.Security.AccessControl.6.0.0
- System.Security.Permissions.6.0.0
- System.Security.Principal.Windows.5.0.0
- System.Text.Encodings.Web.6.0.0
- System.Text.Json.6.0.5
- System.Threading.Tasks.Extensions.4.5.4
- System.ValueTuple.4.5.0

### Added:
- Folder [Commands]
  - Folder [Modules] (Active modules for interaction with commands).
  - Folder [Processor]
    - Change.cs (Was added to quickly change the value using a command).
    - Support.cs (Was added to fix bugs. I used it as a chat clearer after writing a command).
    - Users.cs (Human interaction with commands).
- Folder [Configurations]
  - Support.cs (Added to fix errors when loading the config).
  - Variables.cs (Effective variables).
  - YandexConfig.cs (Loading system and saving config).
- Folder [Console]
  - Settings.cs (Initial console software settings).
- Folder [Help]
  - Commandors.txt (Help for users).
- Folder [Hotkeys]
  - Bindings.cs (Simple hotkeys system).
- Folder [Manifest?]
  - app.manifest (Needed to open the program as administrator).
- Folder [Text]
  - Language.cs (Simple language system).
  - Registration.cs (Interacting with console text output).
- Folder [Utilites]
  - Imports.cs (All necessary and unnecessary imports).

### Screen
![ScreenMain](https://github.com/Willemere/Autoclicker/blob/main/menu.png)

### P.S
That's basically it, I was too lazy to do anything.
