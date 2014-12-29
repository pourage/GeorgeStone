using UnityEngine;
using System.Collections;


public class ManaPool 
{
	const int c_iMAXLIMIT = 10;



	//Num determent in the round +1 every round
	int m_iCurrentSize;

	//Num used per round
	int m_iCurrentAvailable;
	
	// Use this for initialization
	public ManaPool()
	{
		m_iCurrentSize = 0;
		m_iCurrentAvailable  = 0;
	}

	//Called at the start of a new Turn
	public void NewTurn()
	{
		m_iCurrentSize++;

		if(m_iCurrentSize > c_iMAXLIMIT)
			m_iCurrentSize = c_iMAXLIMIT;

		m_iCurrentAvailable = m_iCurrentSize;
	}
}
