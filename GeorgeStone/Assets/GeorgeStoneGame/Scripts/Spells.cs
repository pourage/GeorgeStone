using UnityEngine;
using System.Collections;

public class Spells : Card 
{
	//Health And Attack Points

	bool m_bCanAttack;
	bool m_bSumSickness;
	
	override protected void Initialize()
	{
		m_bCanAttack = false;
	}
}
