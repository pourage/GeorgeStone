using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour 
{
	static GameMaster s_GameMaster;

	string m_sName;


	void Awake()
	{
		s_GameMaster = this;
	}



	//Gets Singleton
	public static GameMaster Get()
	{
		return s_GameMaster;
	}


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public string GetPlayerName()
	{
		return m_sName;
	}
}
