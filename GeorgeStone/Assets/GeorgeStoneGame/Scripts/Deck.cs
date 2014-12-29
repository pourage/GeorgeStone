using UnityEngine;
using System.Collections;

public class Deck 
{
	public enum type{George, Rival};

	const int c_iCARDLIMIT = 30;
	
	// null needs to be assigned to ? how?
	private Card[] m_Cards;

	private int m_iTopIdx;

	//Creates the Deck and Shuffles
	public Deck(type t)
	{
		if(t == type.George)
		{
			LoadGeorgeDeck();
		}
		else
		{
			LoadRivalDeck();

		}

		Shuffle();
	}

	//Get the Top Card of the Deck
	public Card Draw()
	{
		if( m_iTopIdx >= c_iCARDLIMIT )
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

	void Shuffle()
	{
		//Shuffle
		for(int i = 0; i < c_iCARDLIMIT; i ++)
		{
			int ran = Random.Range(0, c_iCARDLIMIT);

			// Copy card at idx
			Card A = m_Cards[i];

			//card at i =
			m_Cards[i] = m_Cards[ran];
			m_Cards[ran] = A;
		}
	}

	//My Cards
	void LoadGeorgeDeck()
	{

	}

	//A.I Cards
	void LoadRivalDeck()
	{

	}
}
