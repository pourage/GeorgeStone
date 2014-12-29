using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player   
{
	protected string m_sName;
	int    m_iHealth;
	public const int c_iMAXHEALTH = 30;

	protected Deck m_Deck;
	protected Hand m_Hand;
	protected ManaPool m_ManaPool;

	protected bool m_bIsActiveTurn;

	public enum phase{Start, Draw, Main,Cleanup,End,Waiting};
	protected phase m_ePhase;

	int m_iTurnCount;


	void Update()
	{
		switch(m_ePhase)
		{
		case phase.Start:
			//Check the baord
			m_ManaPool.NewTurn();

			List <Minion> m = Board.Get().GetActivePlayersMinions();

			for( int i = 0; i < m.Count; ++i)
			{
				if(m[i].GetAbility() == Minion.ability.Start)
				{
					m[i].ActivateAbility();
				}
			}

			// need a sec Sleep right here
			break;
		case phase.Draw:
			m_Hand.AddCard(m_Deck.Draw());
			break;
		case phase.Main:
			//Check
			break;
		case phase.Cleanup:
			//Check
			break;
		case phase.End:
			break;
		case phase.Waiting:
			break;
		}
	}
	
	public void SwitchPhase(phase next)
	{
		m_ePhase = next;
	}

	public Player()
	{

	}

	public void AddHealth(int n)
	{
		m_iHealth +=n;
		if(m_iHealth > c_iMAXHEALTH)
			m_iHealth  = c_iMAXHEALTH;
	}

	public void SubtractHealth(int n)
	{
		m_iHealth -=n;
		if(m_iHealth < 0)
		{
			//END GAME
			Debug.Log("Game Over");
		}

	}


	public Player(string name)
	{
		m_sName = name;
	}

	public void Reset()
	{
		m_iHealth = c_iMAXHEALTH;
		m_ePhase = phase.Waiting;
		m_iTurnCount = 0;
	}

	void Initialize()
	{


		//ManaPool.Inital;
		//M_Hand.Initial;
		//M_Deck.Initial;
		//m_Deck.Draw()
		//m_Deck.Draw()
		//m_Deck.Draw()
 
	}



	public void DrawStartingHand(int num)
	{
		//Fill This in
	}

	void Draw()
	{

	}
}
