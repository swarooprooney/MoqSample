using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqDataModel;

namespace MoqBusiness
{

	public interface IScoutPlayer
	{
		string GetPlayerDescription(Player player);
	}
	public class ScoutPlayer : IScoutPlayer
	{
		public string GetPlayerDescription(Player player)
		{
			if (player.Age < 20)
			{
				return @"Teenage SuperStar";
			}

			if (player.Age >= 20 && player.Age < 30)
			{
				return @"First Team";
			}

			if (player.Age >= 30 && player.Age < 35)
			{
				return @"Last contract";
			}

			return @"Do you really want to sign him";
		}
	}
}
