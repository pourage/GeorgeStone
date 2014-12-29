using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//A board has Zones and game Rules
public class Board 
{
	const int c_iMAXMINIONS = 7;

	static Board s_Board;

	MinionZone[] m_ActivePlayerZone;
	MinionZone[] m_OpponentZone;


	public  Board()
	{
		s_Board = this;
		m_ActivePlayerZone 	= new MinionZone[c_iMAXMINIONS];
		m_OpponentZone		= new MinionZone[c_iMAXMINIONS];
	}

	//Get Singelton
	public static Board Get()
	{
		return s_Board;
	}
	/// <summary>
	/// Gets the active players minions on the Board.
	/// </summary>
	/// <returns>The active players minions.</returns>
	public List<Minion> GetActivePlayersMinions()
	{
		List<Minion> minions = new List<Minion>();
		foreach(MinionZone mz in m_ActivePlayerZone)
		{
			if(mz.IsOccupied())
			{
				minions.Add(mz.GetMinion());
			}
		}

		return minions;
	}



}
