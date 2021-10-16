using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IRepository<T>
	{
		public void Create(T model);
		public Task<T> GetAsync(object model);
		public List<T> GetAll();
		public void Update(T model);
		public void Delete();

	}
}
