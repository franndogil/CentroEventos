namespace   CentroEventos.Aplicacion.Interfaces;

using CentroEventos.Aplicacion.Entidades;

public interface IRepositorioEventoDeportivo
{
    //Deben manejar las operaciones CRUD básicas necesarias para
    //los casos de uso y asegurar que los datos persistan entre ejecuciones del programa
    void Agregar (EventoDeportivo eventoDeportivo);
    void Eliminar (int id);
    void Modificar (EventoDeportivo eventoDeportivo);
    List<EventoDeportivo> ListarEventosDisponibles();
    List<Persona> ListarPresentes(int id);
    bool ExistePorId(int id);
    bool ExisteReponsablePorId(int id);
    EventoDeportivo ObtenerPorId (int id);
    List<EventoDeportivo> Listar ();
}