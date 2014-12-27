using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	static GameManager s_GameManager;

	Board m_Board;


	void Awake()
	{
		s_GameManager = this;
	}

	//Initalize all Objects in the scene
	void InitializeSinglePlayer()
	{

	}

}
