using System;
using System.Collections.Generic;
using MoqDataModel;
using MoqDataRepos;

namespace MoqBusiness
{
	public class RoosterService : IRoosterService
	{
		private readonly IPlayersRepo _players;

		public RoosterService(IPlayersRepo players)
		{
			_players = players;
		}
		

		public IList<Player> GetPlayersFromRepo()
		{
			return _players.GetPlayerList();
		}
	}
}
