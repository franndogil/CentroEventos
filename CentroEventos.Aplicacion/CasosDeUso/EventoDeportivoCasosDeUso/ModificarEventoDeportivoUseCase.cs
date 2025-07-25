using System;
using CentroEventos.Aplicacion.Interfaces;
using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.Excepciones;
using CentroEventos.Aplicacion.Validadores;
using CentroEventos.Aplicacion.Enumerativos;

namespace CentroEventos.Aplicacion.CasosDeUso.ReservaCasosDeUso;

public class ModificarEventoDeportivoUseCase(IRepositorioEventoDeportivo repoEventoDeportivo,  IRepositorioPersona repoPersona, IServicioAutorizacion Auth, EventoDeportivoValidador eventoDeportivoValidador)
{
    public void Ejecutar(EventoDeportivo eventoDeportivo, Usuario usuario)
    {
       
         if(!Auth.PoseeElPermiso(usuario.Permisos, Permiso.EventoAlta ))
        {
            throw new FalloAutorizacionException("Usuario no autorizado");
        } 

        if(!eventoDeportivoValidador.Validar(eventoDeportivo, out string mensajeError))
        {
            throw new ValidacionException(mensajeError);
        }

        if(!repoEventoDeportivo.ExistePorId(eventoDeportivo.Id))
        {
            throw new EntidadNotFoundException("Id del evento no corresponde a un evento registrado.\n");
        }
        
        if (!repoPersona.ExistePorId(eventoDeportivo.ResponsableId))
        {
            throw new EntidadNotFoundException("Id del responsable no corresponde a una persona registrada.\n");
        }

        if (eventoDeportivo.FechaHoraInicio > DateTime.Now)
        {
            throw new OperacionInvalidaException("El evento deportivo expiró.");
        }
        
        repoEventoDeportivo.Modificar(eventoDeportivo);
    }
}
