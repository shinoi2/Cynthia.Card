using System.Linq;
using System.Threading.Tasks;
using Alsein.Utilities;

namespace Cynthia.Card
{
	[CardEffectId("23018")]//无骨者
	public class Maerolorn : CardEffect
	{//从牌组打出1张拥有遗愿能力的铜色单位牌。
		public Maerolorn(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}