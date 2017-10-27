
namespace Group2_CardGames.Models
{
	public interface IGameLogic
	{
		void BetMoney(int betAmount);
		int WinMoney();
		bool CheckWin();
		void PlayRound();
		void KickPlayer(Player player);
	}
}
