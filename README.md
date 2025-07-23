# **CentroEventos**

CentroEventos es una aplicación web de gestión de reservas para eventos deportivos, desarrollada con tecnologías .NET y enfocada en buenas prácticas de programación, arquitectura limpia y experiencia de usuario.

---

## Guía de prueba

**Autores**: Conejera Juan Pablo, Dogil Franco Matías, Brizzi Matías  
**Cátedra**: Seminario de Lenguajes – .NET – 1er Semestre 2025  
**Fecha**: 21 de mayo de 2025  

---

## Requisitos previos

- Tener instalado SDK de .NET 8.0  
- Sistema operativo con terminal  
- Descargar desde: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

---

## Estructura del proyecto

```
CentroEventos/
├── CentroEventos.Aplicacion/
│   ├── CasosDeUso/
│   │   ├── EventoDeportivoCasosDeUso/
│   │   ├── PersonaCasosDeUso/
│   │   └── ReservaCasosDeUso/
│   ├── Entidades/
│   ├── Enumerativos/
│   ├── Excepciones/
│   ├── Interfaces/
│   ├── Servicios/
│   └── Validadores/
├── CentroEventos.UI/
└── CentroEventos.Repositorios/
    └── utils/
```

---

## Pasos para ejecutar

1. Descomprimir el archivo .ZIP  
2. Abrir una terminal en la carpeta `CentroEventos/CentroEventos.UI`  
3. Ejecutar para compilar:
    ```bash
    dotnet build
    ```
4. Ejecutar el programa:
    ```bash
    dotnet run
    ```

---

## Descripción

La plataforma permite a organizadores de eventos deportivos crear y gestionar eventos, y a usuarios registrarse y reservar entradas de manera ágil y segura.

**Características principales:**
- Gestión de usuarios y roles (administrador, organizador y cliente).
- CRUD de eventos deportivos (crear, editar, eliminar, listar).
- Sistema de reservas con control de disponibilidad.
- Autenticación y autorización con JWT.
- Interfaz web responsiva desarrollada en Blazor.

---

## Tecnologías utilizadas

- **Back-end:** C#, .NET 8.0, ASP.NET Core  
- **Front-end:** Blazor Server  
- **ORM:** Entity Framework Core  
- **Consultas:** LINQ  
- **Base de datos:** SQLite  
- **Patrón de diseño:** CQRS y repositorios  
- **Autenticación:** JSON Web Tokens (JWT)  
- **Control de versiones:** Git & GitHub  

---

## Contribuciones

¡Todas las contribuciones son bienvenidas! Para contribuir:

1. Haz un **fork** del repositorio.  
2. Crea una rama con tu feature: `git checkout -b feature/nombre`.  
3. Realiza tus cambios y haz **commit**.  
4. Envía un **pull request** describiendo tu aporte.  
