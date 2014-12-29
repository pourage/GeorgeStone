using UnityEngine;
using System.Collections;

public class SinglePlayerManager : MonoBehaviour 
{
	SinglePlayerManager s_SPM;

	NonPlayer	    m_NonPlayer;
	MainPlayer 		m_MainPlayer;

	Board			m_Board;
	
	Player          m_ActivePlayer;
	int m_iTurnCount;
	

	//Player m_Current
	void Awake()
	{
		s_SPM = this;
	}

	public void InitializeNewGame()
	{
		string enemyName = "Rival Canidate";

		m_NonPlayer 	= new NonPlayer(enemyName);
		m_MainPlayer	= new MainPlayer(GameMaster.Get().GetPlayerName());

		m_Board			= new Board();
		m_ActivePlayer 	= new Player();
		m_iTurnCount 	= 0;
	}

	//Who is Dertemined to go first
	void CoinFlip()
	{
		//After who is determine who may go first
		//Have players draw staring hand
		const int firstPlayerHandSize 	= 3;
		const int secondPlayerHandSize	= 4;

		int r = Random.Range(0,1);

		//Heads Activeplayer goes first
		if(r == 0)
		{
			m_ActivePlayer = m_MainPlayer;

			m_MainPlayer.DrawStartingHand(firstPlayerHandSize);
			m_NonPlayer.DrawStartingHand(secondPlayerHandSize);

		}
		//Tails NonPlayer goes first
		else
		{
			m_ActivePlayer = m_NonPlayer;

			m_MainPlayer.DrawStartingHand(secondPlayerHandSize);
			m_NonPlayer.DrawStartingHand(firstPlayerHandSize);
		}

		//First

	}

	void GameStartCountDown()
	{



	}


	void UpdateGameLoop()
	{

		m_ActivePlayer.SwitchPhase(Player.phase.Start);

		//Stand by phase
		// Draw phase
		// Main Phase
		// Clean up Phase
		// End Phase

	}





























}
