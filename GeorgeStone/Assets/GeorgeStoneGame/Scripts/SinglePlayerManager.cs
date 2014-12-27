using UnityEngine;
using System.Collections;

public class SinglePlayerManager : MonoBehaviour 
{
	SinglePlayerManager s_SPM;

	AutomatedUser 	m_NonUser;
	User 			m_ActiveUser;

	Board			m_Board;
	
	Player m_ActivePlayer;
	
	//Player m_Current
	void Awake()
	{
		s_SPM = this;
	}

	public void InitializeNewGame()
	{
		m_NonUser 	= new AutomatedUser();
		m_ActiveUser= new User();
		m_Board		= new Board();
		m_ActivePlayer = new Player();
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
			m_ActivePlayer = m_ActiveUser;

			m_ActiveUser.DrawStartingHand(firstPlayerHandSize);
			m_NonUser.DrawStartingHand(secondPlayerHandSize);

		}
		//Tails NonPlayer goes first
		else
		{
			m_ActivePlayer = m_NonUser;

			m_ActiveUser.DrawStartingHand(secondPlayerHandSize);
			m_NonUser.DrawStartingHand(firstPlayerHandSize);
		}
	}



	void UpdateGameLoop()
	{



		//Stand by phase
		// Draw phase
		// Main Phase
		// Clean up Phase
		// End Phase

	}





























}
