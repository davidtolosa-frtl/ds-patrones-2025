# Patrones de Diseño en C#

Repositorio educativo con implementaciones prácticas de patrones de diseño (Design Patterns) en C# usando .NET 8.0 y .NET 9.0.

## 📋 Contenido

Este repositorio contiene ejemplos completos y funcionales de los siguientes patrones de diseño:

### Patrones Creacionales

- **[Singleton](#singleton)** - Sistema de logging con instancia única
- **[Builder](#builder)** - Construcción flexible de casas
- **[Abstract Factory](#abstract-factory)** - Tres implementaciones diferentes:
  - Elementos de interfaz de usuario (Windows/Linux)
  - Sistema bancario con paquetes de productos
  - Catálogo de vehículos por tipo de combustible

### Patrones de Comportamiento

- **[Strategy](#strategy)** - Diferentes estrategias de visualización de catálogos

### Patrones Estructurales

- **[Adapter](#adapter)** - Adaptación de interfaces incompatibles
- **[Facade](#facade)** - Fachada para simplificar sistemas complejos
- **[Composite](#composite)** - Jerarquía de empresas con cálculo de costes

## 🚀 Requisitos

- .NET 8.0 SDK o superior
- .NET 9.0 SDK (recomendado)
- Visual Studio 2022, Visual Studio Code, o cualquier editor compatible con C#

## 💻 Cómo Ejecutar

Cada patrón es un proyecto independiente. Para ejecutar cualquier ejemplo:

```bash
# Navegar al directorio del proyecto
cd "Creacionales/Singleton/Logger"

# Ejecutar el proyecto
dotnet run
```

## 📚 Patrones Implementados

### Singleton

**Ubicación:** `Creacionales/Singleton/Logger/`

Sistema de logging que garantiza una única instancia del logger en toda la aplicación.

```bash
cd "Creacionales/Singleton/Logger"
dotnet run
```

**Características:**
- Implementación thread-safe
- Instancia única garantizada
- Ejemplo práctico de logging

---

### Builder

**Ubicación:** `Creacionales/Builder/`

Constructor de casas con API fluida que permite crear objetos complejos paso a paso.

```bash
cd "Creacionales/Builder"
dotnet run
```

**Características:**
- API fluida (Fluent Interface)
- Construcción paso a paso
- Configuración opcional de características (habitaciones, baños, piscina, jardín, color, metros cuadrados)

**Ejemplo de uso:**
```csharp
Casa casa = new CasaBuilder()
    .SetColor("Azul")
    .SetCantidadBaños(2)
    .SetCantidadHabitaciones(3)
    .SetTieneJardin(true)
    .SetTienePiscina(true)
    .SetMetrosCuadrados(120)
    .Build();
```

---

### Abstract Factory

El patrón más completo del repositorio, con **tres implementaciones diferentes** que demuestran su versatilidad.

#### 1. Interfaz de Usuario Multiplataforma

**Ubicación:** `Creacionales/Abstract Factory/InterfazUsuario/`

Crea elementos de UI específicos para diferentes sistemas operativos.

```bash
cd "Creacionales/Abstract Factory/InterfazUsuario"
dotnet run
```

**Características:**
- Soporte para Windows y Linux
- Elementos: Botones y Checkboxes
- Detección automática del SO
- Fácil extensión a nuevas plataformas (macOS, etc.)

**Estructura:**
- `IGUIFactory` - Factory abstracto
- `WindowsGUIFactory`, `LinuxGUIFactory` - Factories concretos
- `IButton`, `ICheckbox` - Productos abstractos
- Implementaciones específicas por plataforma

#### 2. Sistema Bancario

**Ubicación:** `Creacionales/Abstract Factory/Banco/BancoApp/`

Sistema bancario con tres paquetes de productos: Classic, Gold y Platinum.

```bash
cd "Creacionales/Abstract Factory/Banco/BancoApp"
dotnet run
```

**Características:**
- **Paquete Classic:** Productos básicos con límites estándar
- **Paquete Gold:** Beneficios intermedios con cashback
- **Paquete Platinum:** Productos premium con máximos beneficios

**Productos por paquete:**
- Tarjeta de Crédito (límites y tasas variables)
- Caja de Ahorro (tasas de interés diferenciadas)
- Tarjeta de Débito (límites de retiro y beneficios)

**Ejemplo de uso:**
```csharp
var factory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Gold);
var tarjetaCredito = factory.CrearTarjetaCredito();
var cajaAhorro = factory.CrearCajaAhorro();
var tarjetaDebito = factory.CrearTarjetaDebito();
```

#### 3. Catálogo de Vehículos

**Ubicación:** `Creacionales/Abstract Factory/CatalogoVehiculos/`

Catálogo de vehículos organizados por tipo de combustible.

```bash
cd "Creacionales/Abstract Factory/CatalogoVehiculos"
dotnet run
```

**Características:**
- **Gasolina:** Vehículos tradicionales
- **Electricidad:** Vehículos eléctricos
- **Híbridos:** Combinación de ambos

**Tipos de vehículos:**
- Automóviles
- Scooters

---

### Strategy

**Ubicación:** `Comportamiento/Strategy/`

Diferentes estrategias para mostrar un catálogo de vehículos.

```bash
cd "Comportamiento/Strategy"
dotnet run
```

**Características:**
- Estrategia: 1 vehículo por línea
- Estrategia: 3 vehículos por línea
- Estrategia: 5 vehículos por línea
- Cambio dinámico de estrategia en tiempo de ejecución
- Menú interactivo para seleccionar estrategia

**Ventajas:**
- Fácil agregar nuevas estrategias de visualización
- Cambio de comportamiento sin modificar el cliente
- Código más mantenible y extensible

---

### Adapter

**Ubicación:** `Estructurales/Adapter/`

Implementación básica del patrón Adapter.

```bash
cd "Estructurales/Adapter"
dotnet run
```

**Características:**
- Adapta una interfaz incompatible (`Adaptee`) a la interfaz esperada (`ITarget`)
- Ejemplo simple y didáctico
- Demuestra el principio de adaptación de interfaces

---

## 🏗️ Estructura del Proyecto

```
PatronesDiseño/
│
├── Creacionales/
│   ├── Singleton/
│   │   └── Logger/              # Sistema de logging singleton
│   ├── Builder/                 # Constructor de casas
│   └── Abstract Factory/
│       ├── InterfazUsuario/     # UI multiplataforma
│       ├── Banco/               # Sistema bancario
│       └── CatalogoVehiculos/   # Catálogo de vehículos
│
├── Comportamiento/
│   └── Strategy/                # Estrategias de visualización
│
└── Estructurales/
    └── Adapter/                 # Adaptador de interfaces
```

## 🎯 Objetivos de Aprendizaje

Este repositorio te ayudará a comprender:

1. **Patrones Creacionales:** Cómo crear objetos de manera flexible y reutilizable
2. **Patrones de Comportamiento:** Cómo definir la comunicación entre objetos
3. **Patrones Estructurales:** Cómo componer clases y objetos en estructuras más grandes
4. **Principios SOLID:** Especialmente Open/Closed y Dependency Inversion
5. **Separación de responsabilidades**
6. **Código mantenible y extensible**

## 📖 Recursos Adicionales

Cada implementación de Abstract Factory incluye su propio README detallado:

- [Abstract Factory - Interfaz de Usuario](Creacionales/Abstract%20Factory/InterfazUsuario/README.md)
- [Abstract Factory - Sistema Bancario](Creacionales/Abstract%20Factory/Banco/README.md)

## 🤝 Contribuciones

Este es un proyecto educativo. Las sugerencias y mejoras son bienvenidas.

## 📝 Notas

- Los proyectos usan principalmente .NET 9.0
- Algunos proyectos más antiguos usan .NET 8.0
- Todo el código está en español para facilitar el aprendizaje
- Los ejemplos son interactivos y se ejecutan en consola

## 👨‍💻 Uso Educativo

Este repositorio es ideal para:
- Estudiantes de programación orientada a objetos
- Desarrolladores aprendiendo patrones de diseño
- Preparación para entrevistas técnicas
- Material de referencia para cursos de arquitectura de software

---

**¡Explora cada patrón y aprende cómo pueden mejorar tu código! 🚀**
