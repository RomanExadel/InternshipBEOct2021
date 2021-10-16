using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IUserService
	{
		Task<string> Authenticate(string login, string password);
	}
}
