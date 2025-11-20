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

- **[Observer](#observer)** - Sistema de notificaciones de vehículos
- **[Strategy](#strategy)** - Diferentes estrategias de visualización de catálogos

### Patrones Estructurales

- **[Adapter](#adapter)** - Adaptación de interfaces incompatibles
- **[Facade](#facade)** - Fachada para simplificar sistemas complejos
- **[Composite](#composite)** - Jerarquía de empresas con cálculo de costes
- **[Decorator](#decorator)** - Decoración dinámica de visualización de vehículos

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

### Observer

**Ubicación:** `Comportamiento/Observer/`

Sistema de notificaciones donde múltiples observadores son notificados automáticamente cuando el estado de un vehículo cambia.

```bash
cd "Comportamiento/Observer"
dotnet run
```

**Características:**
- Patrón de suscripción/notificación (publish-subscribe)
- Múltiples observadores pueden suscribirse a un sujeto
- Actualización automática cuando cambia el estado del sujeto
- Acoplamiento débil entre sujeto y observadores

**Observadores implementados:**
- **ClienteNotificaciones**: Cliente interesado en cambios del vehículo
- **SistemaAlarma**: Sistema de seguridad que reacciona a cambios
- **RegistroLog**: Sistema de logging que registra todos los cambios

**Estructura:**
- `IObservador` - Interfaz que deben implementar todos los observadores
- `Sujeto` - Clase base que gestiona la lista de observadores
- `Vehiculo` - Sujeto concreto que notifica cuando cambia su descripción
- Observadores concretos que implementan `IObservador`

**Ejemplo de uso:**
```csharp
// Crear vehículo (sujeto)
Vehiculo vehiculo = new Vehiculo();

// Crear observadores
ClienteNotificaciones cliente1 = new ClienteNotificaciones("Juan");
SistemaAlarma alarma = new SistemaAlarma();
RegistroLog log = new RegistroLog();

// Suscribir observadores
vehiculo.Agregar(cliente1);
vehiculo.Agregar(alarma);
vehiculo.Agregar(log);

// Cambiar estado del vehículo - todos los observadores son notificados
vehiculo.Descripcion = "Vehículo en movimiento";
```

**Ventajas:**
- Permite agregar o eliminar observadores dinámicamente
- Los observadores no necesitan conocerse entre sí
- El sujeto no necesita conocer los detalles de los observadores
- Fácil extensión con nuevos tipos de observadores
- Cumple el principio Open/Closed
- Ideal para implementar sistemas de eventos

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

### Facade

**Ubicación:** `Estructurales/Facade/`

Simplifica el uso de un sistema complejo de cine en casa mediante una fachada unificada.

```bash
cd "Estructurales/Facade"
dotnet run
```

**Características:**
- Interfaz simplificada para múltiples subsistemas
- Reduce la complejidad de interacción
- Encapsula la lógica de control de múltiples dispositivos

---

### Composite

**Ubicación:** `Estructurales/Composite/`

Permite componer objetos en estructuras de árbol para representar jerarquías parte-todo. Implementa un sistema de empresas con filiales que calcula costes de mantenimiento de vehículos.

```bash
cd "Estructurales/Composite"
dotnet run
```

**Características:**
- Estructura jerárquica de empresas (madre y filiales)
- Tratamiento uniforme de objetos individuales y compuestos
- Cálculo recursivo de costes de mantenimiento
- Dos tipos de empresas:
  - **EmpresaSinFilial**: Empresa hoja sin filiales
  - **EmpresaMadre**: Empresa compuesta que puede contener filiales

**Estructura:**
- `Empresa` - Componente abstracto base
- `EmpresaSinFilial` - Hoja (leaf) del árbol
- `EmpresaMadre` - Compuesto (composite) que contiene filiales

**Ejemplo de uso:**
```csharp
// Crear empresas sin filiales
Empresa filial1 = new EmpresaSinFilial();
filial1.agregaVehiculo();
filial1.agregaVehiculo();

// Crear empresa madre y agregar filiales
Empresa empresaMadre = new EmpresaMadre();
empresaMadre.agregaVehiculo();
empresaMadre.agregaFilial(filial1);

// Calcular coste total (incluye filiales)
double costeTotal = empresaMadre.calculaCosteMantenimiento();
```

**Ventajas:**
- Simplifica el código del cliente al tratar objetos individuales y compuestos uniformemente
- Facilita agregar nuevos tipos de componentes
- Estructura natural para jerarquías recursivas

---

### Decorator

**Ubicación:** `Estructurales/Decorator/`

Permite añadir funcionalidades adicionales a objetos de forma dinámica. Implementa un sistema de visualización de vehículos donde se pueden agregar características (modelo, marca) mediante decoradores apilables.

```bash
cd "Estructurales/Decorator"
dotnet run
```

**Características:**
- Añade responsabilidades a objetos en tiempo de ejecución
- Alternativa flexible a la herencia para extender funcionalidad
- Los decoradores se pueden apilar en cualquier orden
- Transparencia: decoradores y componentes comparten la misma interfaz
- Composición sobre herencia

**Estructura:**
- `ComponenteGraficoVehiculo` - Interfaz común para componentes y decoradores
- `VistaVehiculo` - Componente concreto base (visualización básica)
- `Decorador` - Clase abstracta decoradora que envuelve un componente
- `ModeloDecorador` - Decorador concreto que añade información del modelo
- `MarcaDecorador` - Decorador concreto que añade información de la marca

**Ejemplo de uso:**
```csharp
// Crear componente base
VistaVehiculo vista = new VistaVehiculo();

// Decorar con información del modelo
ModeloDecorador modeloDecorador = new ModeloDecorador(vista);
modeloDecorador.visualiza();

// Apilar otro decorador para añadir la marca
MarcaDecorador marcaDecorador = new MarcaDecorador(modeloDecorador);
marcaDecorador.visualiza();
```

**Salida esperada:**
```
Visualizando vehículo...
Mostrando modelo del vehículo...
Visualizando vehículo...
Mostrando modelo del vehículo...
Mostrando marca del vehículo...
```

**Ventajas:**
- Más flexible que la herencia estática
- Evita clases sobrecargadas con muchas características en la parte superior de la jerarquía
- Se puede añadir o quitar responsabilidades en tiempo de ejecución
- Se pueden combinar varios decoradores para crear comportamientos complejos
- Cumple el principio Open/Closed (abierto para extensión, cerrado para modificación)

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
│   ├── Observer/                # Sistema de notificaciones
│   └── Strategy/                # Estrategias de visualización
│
└── Estructurales/
    ├── Adapter/                 # Adaptador de interfaces
    ├── Facade/                  # Fachada de sistema de cine
    ├── Composite/               # Jerarquía de empresas
    └── Decorator/               # Decoración de vistas de vehículos
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
