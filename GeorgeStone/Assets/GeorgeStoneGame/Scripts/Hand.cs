using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Hand  
{
	int c_iMaxSize = 10;

	List<Card> m_Cards; 

	public Hand()
	{
		m_Cards = new List<Card>();
	}


	public void AddCard(Card card)
	{
		m_Cards.Add(card);
	}
}
