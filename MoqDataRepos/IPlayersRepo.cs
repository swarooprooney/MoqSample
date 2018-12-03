using System.Collections.Generic;
using MoqDataModel;

namespace MoqDataRepos
{
	public interface IPlayersRepo
	{
		IList<Player> GetPlayerList();
	}
}
