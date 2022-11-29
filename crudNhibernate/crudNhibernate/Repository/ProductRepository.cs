using crudNhibernate.Model;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudNhibernate.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ISession _session;

        public ProductRepository(ISession session)
        {
            _session = session;
        }

        public async Task Add(Product item)
        {
            ITransaction transaction = null;
            try
            {
                transaction = _session.BeginTransaction();
                await _session.SaveAsync(item);
                await transaction.CommitAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            ITransaction transaction = null;
            try
            {
                // return _session.Query<Product>().ToList();
                ICriteria products = _session.CreateCriteria<Product>();

                products.AddOrder(Order.Asc("Id"));

                return await products.ListAsync<Product>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task<Product> FindById(int id)
        {
            ITransaction transaction = null;
            try
            {
                var product = await _session.GetAsync<Product>(id);

                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task<IEnumerable<Product>> FindByName(string name)
        {
            ITransaction transaction = null;
            try
            {
                transaction = _session.BeginTransaction();

                var products = _session.QueryOver<Product>().WhereRestrictionOn(x => x.Name).IsLike("%" + name + "%");

                return await products.ListAsync<Product>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task Remove(int id)
        {
            ITransaction transaction = null;
            try
            {
                transaction = _session.BeginTransaction();
                var item = await _session.GetAsync<Product>(id);
                await _session.DeleteAsync(item);
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task Update(Product item)
        {
            ITransaction transaction = null;
            try
            {
                transaction = _session.BeginTransaction();
                await _session.UpdateAsync(item);
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await transaction?.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                transaction?.Dispose();
            }
        }
    }
}
