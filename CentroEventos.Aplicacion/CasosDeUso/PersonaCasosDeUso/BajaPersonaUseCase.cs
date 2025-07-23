using System;
using System.Net.Security;
using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.Excepciones;
using CentroEventos.Aplicacion.Interfaces;
using CentroEventos.Aplicacion.Enumerativos;
namespace CentroEventos.Aplicacion.CasosDeUso.PersonaCasosDeUso;

public class BajaPersonaUseCase(IRepositorioPersona repoPersona, IRepositorioEventoDeportivo repoEventoDeportivo, IServicioAutorizacion Auth)
{
    public void Ejecutar(int id, Usuario usuario)
    {
        if (!Auth.PoseeElPermiso(usuario.Permisos, Permiso.PersonaBaja))
        {
            throw new FalloAutorizacionException("Usuario no autorizado.");
        }
        if (!repoPersona.ExistePorId(id))
        {
            throw new EntidadNotFoundException("El usuario no existe en la base de datos.");
        }
        if (repoEventoDeportivo.ExisteReponsablePorId(id))
        {
            throw new OperacionInvalidaException("La persona es responsable de uno o mas eventos.");
        }
        repoPersona.Eliminar(id);
    }
}
