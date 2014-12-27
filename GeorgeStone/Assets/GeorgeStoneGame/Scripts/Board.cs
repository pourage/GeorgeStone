using UnityEngine;
using System.Collections;

//A board has Zones and game Rules
public class Board : MonoBehaviour 
{
	const int c_iMaxMinions = 7;

	MinionZone[] m_ActivePlayerZone;
	MinionZone[] m_OpponentZone;

	public void Initialize()
	{
		m_ActivePlayerZone 	= new MinionZone[c_iMaxMinions];
		m_OpponentZone		= new MinionZone[c_iMaxMinions];
	}

}
