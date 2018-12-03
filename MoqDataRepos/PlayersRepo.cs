using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using MoqDataModel;

namespace MoqDataRepos
{
	public class PlayersRepo:IPlayersRepo
	{

		public IList<Player> GetPlayerList()
		{
			var playerList = new List<Player> {
				new Player { Name = "Swaroop", Age = 28 ,PlayersClub = new Club{ ClubName = "Manchester United",CountryName = "GB",Position = 7} },
				new Player { Name = "Seema", Age = 30 ,PlayersClub = new Club{ ClubName = "Manchester United",CountryName = "GB",Position = 7}},
					new Player { Name = "Jay", Age = 35 ,PlayersClub = new Club{ ClubName = "Arsenal",CountryName = "GB",Position = 4}},
				new Player { Name = "Don", Age = 30 ,PlayersClub = new Club{ ClubName = "Manchester City",CountryName = "GB",Position = 1}}
			};
			return playerList;
		}
	}
}
