# RimWorld .NET Mod Template

A comprehensive template for creating RimWorld mods using C# and .NET Framework 4.8.1. This template includes examples of common mod components and follows RimWorld modding best practices.

I will be updating more boilerplate code examples in the future.

## Features

This template provides examples and boilerplate code for:

- ✅ **Basic mod structure** with proper project configuration
- ✅ **Snippets** for common classes
- ✅ **Custom Defs** with XML and C# examples
- ✅ **Job Drivers** for custom pawn behaviors
- ✅ **Hediff Components** for health effects and conditions
- ✅ **Incident Workers** for custom events
- ✅ **DefOf patterns** for type-safe definition references
- ✅ **Settings framework** with mod configuration support
- ✅ **Harmony integration** for patching game code (referenced with nuget package, but no examples yet)
- ✅ **Automatic build and test** integration

## Prerequisites

- **Visual Studio 2019/2022** or **Visual Studio Code** with C# extension
- **.NET Framework 4.8.1** SDK
- **RimWorld** installed (for assembly references)
- **Git** (optional, for version control)

## Quick Start

### Option 1: Using as .NET Template (Recommended)

#### Install this Template

1. Clone this repo
    ```
    git clone https://github.com/Anarcho/RimModTemplate.git "RimModTemplate"
    ```

2. Enter directory
    ```
    cd RimModTemplate
    ```
3. Run command to install the template
    ```
    dotnet new --install .
    ```

#### Run this Template

1. Create a new mod folder in your Rimworld installation directory.
    ```
    mkdir "YourModName"
    ```

2. Enter directory
    ```
    cd "YourModName"
    ```

3. Run command
    ```
    dotnet new rimworldmod
    ```

#### Note:
Project references are using relative paths, however, you may need to update if not setup by default. 
*See configuration section*.


### Option 2: Manual Setup (Not Recommended)

1. Clone or download this template
2. Rename the folder to your mod name
3. Update the following files with your mod information:
   - `About/About.xml` - Mod metadata
   - `RimModTemplate.csproj` - Project name and assembly references
   - `RimModTemplate.cs` - Main mod class

## Project Structure

```
YourMod/
├── About/
│   └── About.xml                 # Mod metadata and description
├── Assemblies/                   # Compiled DLLs (auto-generated)
├── Defs/                        # XML definitions
│   ├── CustomDef/
│   ├── HediffDefs/
│   └── JobDefs/
├── Patches/                     # XML patches for existing content
├── Sounds/                      # Audio files
├── RimModTemplate/              # C# source code
│   ├── CustomDef/
│   ├── HediffComps/
│   ├── IncidentWorker/
│   ├── JobDrivers/
│   ├── DefOf.cs                 # Type-safe def references
│   ├── RimModTemplate.cs        # Main mod class
│   └── RimModTemplate.csproj    # Project configuration
├── LoadFolders.xml              # Version-specific loading
└── README.md
```

## Configuration

### 1. Assembly References

Update the RimWorld assembly paths in `RimModTemplate.csproj`:

```xml
<Reference Include="Assembly-CSharp">
  <HintPath>C:\Path\To\RimWorld\RimWorldWin64_Data\Managed\Assembly-CSharp.dll</HintPath>
  <Private>False</Private>
</Reference>
```

### 2. Output Path

The template is configured to output assemblies to the `Assemblies` folder. Adjust the `BaseOutputPath` if needed:

```xml
<BaseOutputPath>C:\Path\To\Your\Mod\Assemblies</BaseOutputPath>
```

### 3. Post-Build Testing
The template includes automatic RimWorld launching for testing. Update the path in the PostBuild event:
```xml
<Exec Command="C:\Path\To\RimWorld\RimWorldWin64.exe -quicktest" />
```

## Examples Included

### Custom Definitions

**C# Class** (`CustomDef/ExampleCustomDef.cs`):
```csharp
public class ExampleCustomDef : Def
{
    public string customProperty1;
    public string customProperty2;
}
```

**XML Definition** (`Defs/CustomDef/ExampleModTemplate_CustomDef.xml`):
```xml
<ExampleModTemplate.CustomDef>
  <defName>ExampleCustomDef</defName>
  <label>Example Custom Definition</label>
  <customProperty1>Value1</customProperty1>
  <customProperty2>Value2</customProperty2>
</ExampleModTemplate.CustomDef>
```

### Job Drivers

Defines custom behaviors for pawns:
- `JobDriver_ExampleJobDriver` - Template for pawn jobs
- Includes reservation system and toil sequences
- Integrated with JobDef XML definitions

### Hediff Components

Health effect components with:
- Custom properties and behaviors
- Save/load functionality (`CompExposeData`)
- Tick-based updates
- Debug information display

### DefOf Pattern

Type-safe references to your definitions:
```csharp
[DefOf]
public static class RimModTemplateDefOf
{
    public static JobDef ExampleJobDef;
    public static ExampleCustomDef ExampleCustomDef;
}
```

## Building and Testing

### Development Build

Development build will launch rimworld as a post action - you can change this functionality in the csproj file.
```powershell
dotnet build
```

### Release Build
```powershell
dotnet build -c Release
```

## Best Practices

1. **Naming Conventions**
   - Use your mod name as namespace
   - Prefix DefNames with your mod identifier
   - Follow C# naming conventions

2. **Performance**
   - Minimize tick-based operations
   - Use caching for expensive calculations
   - Properly dispose of resources

3. **Compatibility**
   - Test with popular mods
   - Use Harmony patches sparingly
   - Document mod interactions

## Troubleshooting

### Common Issues

**Build Errors:**
- Check RimWorld assembly paths in `.csproj`
- Ensure .NET Framework 4.8.1 is installed
- Verify RimWorld version compatibility

**Runtime Errors:**
- Check RimWorld logs at `%USERPROFILE%\AppData\LocalLow\Ludeon Studios\RimWorld by Ludeon Studios\Player.log`
- Enable developer mode in RimWorld for detailed error messages
- Validate XML syntax in definition files

**Loading Issues:**
- Verify `About.xml` format
- Check `LoadFolders.xml` version matching
- Ensure mod dependencies are loaded first

## Contributing

When contributing to this template:

1. Test with multiple RimWorld versions
2. Update documentation for new features
3. Follow existing code patterns
4. Include XML examples for new C# components

## Resources

- [RimWorld Modding Wiki](https://rimworldwiki.com/wiki/Modding)
- [Harmony Documentation](https://harmony.pardeike.net/)
- [RimWorld Community Discord](https://discord.gg/rimworld)
- [Ludeon Forums - Mods](https://ludeon.com/forums/index.php?board=12.0)

## Inspired by
- [ZetaRimwold-Dotnet-Template](https://github.com/Zeta-of-the-rim/Rimwold-Dotnet-Template/tree/main)

## License

This template is provided as-is for educational and development purposes. Individual mods created from this template should include their own license terms.

---
