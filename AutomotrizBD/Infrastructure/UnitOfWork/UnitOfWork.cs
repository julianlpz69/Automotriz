using Core.Interfaces;

using Infrastructure.Data;
using Infrastructure.Repository;



namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AutomotrizBDContext context;
    private ClienteRepository _clientes;


    public UnitOfWork(AutomotrizBDContext _context)
    {
        context = _context;
    }

    public ICliente Clientes
    {
        get{
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(context);
            }
            return _clientes;
        }

    }


    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
