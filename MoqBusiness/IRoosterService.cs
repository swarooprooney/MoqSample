using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqDataModel;

namespace MoqBusiness
{

	public interface IRoosterService
	{
		IList<Player> GetPlayersFromRepo();
	}
}
