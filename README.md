# WineAppBackEnd

**WineAppBackEnd** es una API para la gestión de inventario de vinos, diseñada para registrar usuarios, agregar vinos y consultar el stock disponible. La aplicación utiliza ASP.NET Core y sigue una arquitectura basada en servicios.

## Tabla de Contenidos

- [Descripción](#descripción)
- [Requisitos Previos](#requisitos-previos)
- [Instalación](#instalación)
- [Uso](#uso)
- [Endpoints](#endpoints)
  - [UserController](#usercontroller)
  - [WineController](#winecontroller)
- [Configuración](#configuración)

## Descripción

Esta aplicación permite gestionar el inventario de vinos, proporcionando endpoints para agregar nuevos usuarios, registrar vinos y consultar el stock disponible. El proyecto está estructurado en capas para mejorar la mantenibilidad y escalabilidad del código.

## Requisitos Previos

Antes de comenzar, asegúrate de tener instalados los siguientes requisitos:

- [SDK de .NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- Un entorno de desarrollo (por ejemplo, [Visual Studio](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/))

## Instalación

Sigue estos pasos para poner en marcha el proyecto:

1. Clona este repositorio:

    ```bash
    git clone https://github.com/usuario/WineAppBackEnd.git
    ```

2. Navega hasta el directorio del proyecto:

    ```bash
    cd WineAppBackEnd
    ```

3. Restaura las dependencias del proyecto:

    ```bash
    dotnet restore
    ```

4. Compila la solución:

    ```bash
    dotnet build
    ```

## Uso

Para ejecutar el servidor de la API en un entorno local:

```bash
dotnet run
```

La API estará disponible en `https://localhost:5001`. Puedes interactuar con los endpoints utilizando herramientas como [Postman](https://www.postman.com/) o [cURL](https://curl.se/).

## Endpoints

### UserController

Maneja la creación de usuarios en el sistema.

- **POST** `/api/user`: Agrega un nuevo usuario.

  **Body de la solicitud:**
  ```json
  {
    "username": "john_doe",
    "password": "mypassword123",
    "email": "john.doe@example.com"
  }
  ```

  **Posibles respuestas:**
  - `201 Created`: Usuario creado correctamente.
  - `400 Bad Request`: Si el usuario ya existe o el cuerpo de la solicitud es inválido.

### WineController

Maneja las operaciones relacionadas con el inventario de vinos.

- **POST** `/api/wine`: Agrega un nuevo vino al inventario.

  **Body de la solicitud:**
  ```json
  {
    "name": "Merlot",
    "year": 2019,
    "quantity": 50
  }
  ```

  **Posibles respuestas:**
  - `201 Created`: Vino registrado correctamente.
  - `400 Bad Request`: Si el vino ya está registrado o la solicitud es inválida.

- **GET** `/api/wine`: Devuelve el inventario actual de vinos.

  **Posibles respuestas:**
  - `200 OK`: Devuelve una lista con todos los vinos y sus cantidades en stock.

## Configuración

El archivo de configuración `appsettings.json` se utiliza para definir las variables de entorno, como la conexión a la base de datos y otros parámetros relevantes. Asegúrate de actualizarlo con los valores correctos antes de ejecutar la aplicación en un entorno de producción.

