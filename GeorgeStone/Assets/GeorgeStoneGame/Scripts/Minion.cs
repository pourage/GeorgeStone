using UnityEngine;
using System.Collections;

public class Minion : Card 
{
	//Health And Attack Points
	int m_iHP;
	int m_iAP;

	bool m_bCanAttack;
	bool m_bSumSickness;

	public enum state {waiting,summon, idle, attack, death}
	public enum ability { None,Start,Global,Target,BattleCry, DeathRattle};

	state m_eState;
	ability m_eAbility;

	override protected void Initialize()
	{
		m_bCanAttack = false;
		m_eState = state.waiting;
		m_eAbility = ability.None;
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

	//
	public virtual void ActivateAbility()
	{
		//Have the Card do something here
	}

	public ability GetAbility()
	{
		return m_eAbility; 
	}
}
