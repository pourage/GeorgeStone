using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	string m_sName;
	int    m_iHealth;
	
	public Card[] m_Deck;
	Hand m_Hand;
	ManaPool m_Pool;

	bool m_bIsActiveTurn;

	public enum phase{Standby, Draw, Main,Cleanup,End,Waiting};
	phase m_ePhase;


	void Update()
	{
		switch(m_ePhase)
		{
		case phase.Standby:
			//Check the baord
			break;
		case phase.Draw:
			
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
	
	public void SwithPhase(phase next)
	{
		m_ePhase = next;
	}
	void Initialize()
	{
		m_iHealth = 30;
		m_ePhase = phase.Waiting;

		//ManaPool.Inital;
		//M_Hand.Initial;
		//M_Deck.Initial;
		//m_Deck.Draw()
		//m_Deck.Draw()
		//m_Deck.Draw()
 
	}

	public void DrawStartingHand(int num)
	{
	
	}

	void Draw()
	{

	}
}
