using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqBusiness;
using MoqDataRepos;
namespace MoqSampleMain
{
	class Program
	{
		static void Main(string[] args)
		{
			var playersObj = new RoosterService(new PlayersRepo());
			var players = playersObj.GetPlayersFromRepo();

			var scout = new ScoutPlayer();

			foreach (var player in players)
			{
				Console.WriteLine(player.Name + " "+ scout.GetPlayerDescription(player));
			}

			Console.ReadLine();
		}
	}
}
