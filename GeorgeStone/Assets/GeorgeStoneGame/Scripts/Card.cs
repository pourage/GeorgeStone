using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour 
{
	protected int m_iManaCost;
	protected int m_iIDNumber;

	enum abillites {Global,Target,BattleCry, DeathRattle};




	protected virtual void Initialize()
	{

	}


	public int GetManaCost()
	{
		return m_iManaCost;
	}

	//Return a Card using the 
	public Card Target()
	{
		return null;
	}

	public void Phase()
	{

	}


}
