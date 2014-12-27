using UnityEngine;
using System.Collections;

public class Deck : MonoBehaviour 
{
	const int c_iCardMax = 30;

	// null needs to be assigned to ? how?
	private Card[] m_Cards;

	private int m_iTopIdx;

	//Creates the Deck and Shuffles
	public void Initialize()
	{
		//This is going to do branch to which player so we know which Deck to Initialize
	}

	//Get the Top Card of the Deck
	public Card Draw()
	{
		if( m_iTopIdx >= c_iCardMax )
		{
			//Draw Self Damage Cards
		}

		if(m_Cards[m_iTopIdx] == null)
		{
			Debug.Log("Have a Null when Drawing a Card, Whats up with that?");
			return null;
		}

		return m_Cards[m_iTopIdx++];
	}

	//My Cards
	void LoadGeorgeDeck()
	{

	}

	//A.I Cards
	void LoadCanidateDeck()
	{

	}
}
