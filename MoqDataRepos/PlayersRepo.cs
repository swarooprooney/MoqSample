using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using MoqDataModel;

namespace MoqDataRepos
{
	public class PlayersRepo
	{

		public IList<Player> GetPlayerList()
		{
			var playerList = new List<Player> { new Player { Name = "swaroop", Age = 28, new Club { ClubName = "Manchester United", CountryName = "GB", Position = 7 } } };

		}
	}
}
