using UnityEngine;
using System.Collections;

public class VisualManager : MonoBehaviour 
{
	//Main Player
	Player m_MainPLayer;
	Player m_RivalPlayer;

	static VisualManager s_VisualManager;

	void Initialize(Player m, Player r)
	{
		s_VisualManager = this;
	}

	public static VisualManager Get()
	{
		return s_VisualManager;
	}
}
