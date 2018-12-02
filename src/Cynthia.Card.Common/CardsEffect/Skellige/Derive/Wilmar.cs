using System.Linq;
using System.Threading.Tasks;
using Alsein.Utilities;

namespace Cynthia.Card
{
	[CardEffectId("65007")]//威尔玛
	public class Wilmar : CardEffect
	{//遗愿：若为对方回合，则在对面此排生成1头“熊”。 间谍。
		public Wilmar(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}