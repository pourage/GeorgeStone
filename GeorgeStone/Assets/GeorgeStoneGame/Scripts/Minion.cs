using UnityEngine;
using System.Collections;

public class Minion : Card 
{
	//Health And Attack Points
	int m_iHP;
	int m_iAP;

	bool m_bCanAttack;
	bool m_bSumSickness;

	enum state {waiting,summon, idle, attack, death}
	state m_eState;

	override protected void Initialize()
	{
		m_bCanAttack = false;
		m_eState = state.waiting;
	}

	void Update()
	{
		switch(m_eState)
		{
		case state.waiting:
			break;
		case state.summon:
			break;
		case state.idle:
			break;
		case state.attack:
			break;
		case state.death:
			break;
		}
	}
}
