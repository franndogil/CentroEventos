using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.Excepciones;
using CentroEventos.Aplicacion.Interfaces;
using CentroEventos.Aplicacion.Enumerativos;
public class BajaEventoDeportivoUseCase(IRepositorioEventoDeportivo repoEventoDeportivo, IRepositorioReserva repoReserva, IServicioAutorizacion Auth)
{
    public void Ejecutar(int idEventoDeportivo, Usuario usuario)
    {
         
         if(!Auth.PoseeElPermiso(usuario.Permisos, Permiso.EventoBaja ))
        {
            throw new FalloAutorizacionException("Usuario no autorizado");
        }
        if (!repoEventoDeportivo.ExistePorId(idEventoDeportivo))
        {
            throw new EntidadNotFoundException("El evento deportivo no existe en la base de datos.");
        }
        if (repoReserva.ListarReservasPorEvento(idEventoDeportivo).Count() > 0)
        {
            throw new OperacionInvalidaException("El evento tiene reservas asignadas.");
        }

        repoEventoDeportivo.Eliminar(idEventoDeportivo);
    }
}
