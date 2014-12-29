using UnityEngine;
using System.Collections;

public class MinionZone  
{
	bool m_bIsOccupied;
	Minion m_Minion;


	public MinionZone()
	{
		m_bIsOccupied = false;
		m_Minion = null;
	}

	public bool IsOccupied()
	{
		return  m_bIsOccupied;
	}

	public Minion GetMinion()
	{
		return m_Minion;
	}

	public void SetMinion(Minion m)
	{
		m_Minion = m;
	}



}
