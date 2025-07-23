#**CentroEventos**

CentroEventos es una aplicación web de gestión de reservas para eventos deportivos, desarrollada con tecnologías .NET y enfocada en buenas prácticas de programación, arquitectura limpia y experiencia de usuario.

---

## 📝 Descripción

La plataforma permite a organizadores de eventos deportivos crear y gestionar eventos, y a usuarios registrarse y reservar entradas de manera ágil y segura.

**Características principales:**
- Gestión de usuarios y roles (administrador, organizador y cliente).
- CRUD de eventos deportivos (crear, editar, eliminar, listar).
- Sistema de reservas con control de disponibilidad.
- Autenticación y autorización con JWT.
- Interfaz web responsiva desarrollada en Blazor.

---

## 🚀 Tecnologías

- **Back-end:** C#, .NET 8.0, ASP.NET Core  
- **Front-end:** Blazor Server  
- **ORM:** Entity Framework Core  
- **Consultas:** LINQ  
- **Base de datos:** SQLite  
- **Patrón de diseño:** CQRS y repositorios  
- **Autenticación:** JSON Web Tokens (JWT)  
- **Control de versiones:** Git & GitHub  

---

## 📱 Uso

Para ejecutar la aplicación localmente:

```bash
cd CentroEventos.UI

dotnet run
```

## 🛠️ Estructura del proyecto
CentroEventos
├── CentroEventos.Aplicacion # Lógica de negocio y casos de uso
├── CentroEventos.Repositorios # Implementación de repositorios con EF Core
├── CentroEventos.Sqlite # Inicialización y migraciones de la base de datos
└── CentroEventos.UI # Front‑end Blazor Server

## 🤝 Contribuciones

¡Todas las contribuciones son bienvenidas! Para contribuir:

1. Haz un **fork** del repositorio.  
2. Crea una rama con tu feature: `git checkout -b feature/nombre`.  
3. Realiza tus cambios y haz **commit**.  
4. Envía un **pull request** describiendo tu aporte.  
