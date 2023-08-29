namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
         ICliente Clientes {get; }

         Task<int> SaveAsync();
    }
}