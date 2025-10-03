# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a C# educational repository demonstrating **Design Patterns** (Patrones de Diseño) implementation using .NET 8.0 and .NET 9.0. The project is organized by pattern categories with multiple implementations and examples.

## Repository Structure

The codebase is organized into three main categories of design patterns:

```
PatronesDiseño/
├── Creacionales/          # Creational Patterns
│   ├── Singleton/         # Logger implementation
│   ├── Builder/           # House (Casa) builder
│   └── Abstract Factory/  # Multiple implementations:
│       ├── InterfazUsuario/    # GUI elements (Windows/Linux)
│       ├── Banco/              # Banking system with product packages
│       └── CatalogoVehiculos/  # Vehicle catalog (Gas/Electric/Hybrid)
├── Comportamiento/        # Behavioral Patterns
│   └── Strategy/          # Vehicle catalog display strategies
└── Estructurales/         # Structural Patterns
    ├── Adapter/           # Basic adapter example
    └── Facade/            # Home cinema system facade
```

## Building and Running

Each pattern implementation is a standalone C# console application with its own `.csproj` file.

### Build a specific project
```bash
cd "Creacionales/Singleton/Logger"
dotnet build
```

### Run a specific project
```bash
cd "Creacionales/Singleton/Logger"
dotnet run
```

### Build all projects (from root)
```bash
# Build each project individually
dotnet build "Creacionales/Singleton/Logger/Logger.csproj"
dotnet build "Creacionales/Builder/Builder.csproj"
dotnet build "Creacionales/Abstract Factory/InterfazUsuario/InterfazUsuario.csproj"
dotnet build "Creacionales/Abstract Factory/Banco/BancoApp/BancoApp.csproj"
dotnet build "Creacionales/Abstract Factory/CatalogoVehiculos/CatalogoVehiculos.csproj"
dotnet build "Comportamiento/Strategy/Strategy.csproj"
dotnet build "Estructurales/Adapter/Adapter.csproj"
```

## Pattern Implementations

### Creational Patterns (Creacionales)

**Singleton - Logger**
- Location: `Creacionales/Singleton/Logger/`
- Implements thread-safe logging singleton
- Key file: `LoggerSingleton.cs`

**Builder - Casa**
- Location: `Creacionales/Builder/`
- Builds houses with fluent API (rooms, bathrooms, pool, garden, etc.)
- Key files: `CasaBuilder.cs`, `ICasaBuilder.cs`, `Casa.cs`

**Abstract Factory - Multiple Implementations**

1. **GUI Elements** (`InterfazUsuario/`)
   - Creates OS-specific UI components (Windows/Linux)
   - Factory provider: `GUIFactoryProvider.cs`
   - Factories: `WindowsGUIFactory`, `LinuxGUIFactory`
   - Products: Buttons and Checkboxes for each OS

2. **Banking System** (`Banco/BancoApp/`)
   - Creates product packages: Classic, Gold, Platinum
   - Factory provider: `BancoFactoryProvider.cs`
   - Products: Credit cards, debit cards, savings accounts
   - Each package has different benefits and limits

3. **Vehicle Catalog** (`CatalogoVehiculos/`)
   - Creates vehicles by fuel type: Gas, Electric, Hybrid
   - Factories: `FabricaVehiculosGasolina`, `FabricaVehiculosElectricidad`, `FabricaVehiculosHibridos`
   - Products: Cars and Scooters for each fuel type

### Behavioral Patterns (Comportamiento)

**Strategy - Vehicle Catalog Display**
- Location: `Comportamiento/Strategy/`
- Displays vehicle catalogs with different layouts
- Strategies: `DibujaUnVehiculoPorLinea`, `DibujaTresVehiculosPorLinea`, `DibujaCincoVehiculosPorLinea`
- Context: `VistaCatalogo.cs`

### Structural Patterns (Estructurales)

**Adapter**
- Location: `Estructurales/Adapter/`
- Basic adapter pattern implementation
- Adapts `Adaptee` to `ITarget` interface

## Key Architecture Patterns

### Abstract Factory Pattern Structure
All Abstract Factory implementations follow this structure:
- **Abstract Products**: Interfaces defining product types (e.g., `IButton`, `ICheckbox`)
- **Concrete Products**: OS/type-specific implementations organized in folders (e.g., `Windows/`, `Linux/`)
- **Abstract Factory**: Interface defining creation methods (e.g., `IGUIFactory`)
- **Concrete Factories**: Type-specific factory implementations (e.g., `WindowsGUIFactory`)
- **Factory Provider**: Static class to obtain the appropriate factory based on criteria

### Naming Conventions
- Spanish naming is used throughout (e.g., `Casa`, `Vehiculo`, `Dibuja`)
- Interfaces use `I` prefix (e.g., `IButton`, `ICajaAhorro`)
- Concrete implementations include type suffix (e.g., `WindowsButton`, `TarjetaCreditoGold`)

## .NET Framework Versions
- Most projects target **.NET 9.0** (`net9.0`)
- Some older projects use **.NET 8.0** (`net8.0`)
- All projects have `ImplicitUsings` and `Nullable` enabled

## Testing
There are no unit tests in this repository. This is an educational project focused on demonstrating design pattern implementations.

## Common Development Tasks

When adding a new pattern implementation:
1. Create a new folder under the appropriate category (`Creacionales/`, `Comportamiento/`, or `Estructurales/`)
2. Create a `.csproj` file targeting `net9.0` with `OutputType` set to `Exe`
3. Implement the pattern following the existing structure
4. Add a `Program.cs` with a console demonstration
5. Consider adding a README.md explaining the pattern (see `Abstract Factory` examples)
