﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;


public class RankingData : MonoBehaviour 
{

	public GameObject wall_1;
	//public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
	private GetTime SecondScriptToAccess; 
	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
	private float wall_1_timeBeLooked;
	private float wall_2_timeBeLooked;
	private float wall_3_timeBeLooked;
	private float wall_4_timeBeLooked;
	private float ball_1_timeBeLooked;
	private float ball_2_timeBeLooked;
	private float ball_3_timeBeLooked;
	private float ball_4_timeBeLooked;
	public List<float>DataList = new List<float> ();
	public Text RankedText;
	public List<string> newList;


	void Start () 
	{
		SecondScriptToAccess = wall_1.GetComponent<GetTime> ();

		DataList.Add (SecondScriptToAccess.wall_1_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_2_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_3_timeLooked);
		DataList.Add (SecondScriptToAccess.wall_4_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_1_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_2_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_3_timeLooked);
		DataList.Add (SecondScriptToAccess.ball_4_timeLooked);
	}


	void Update ()
	{
		TimeList ();
//		if (Input.GetKeyDown(KeyCode.S)) 
//		{
		DataList.Sort();
//		Debug.Log (DataList);
		newList = new List<string> () {
			DataList.ToString ()			
		};
//		printOutList ();
		RankedTextList();

//		}
//
//		if (Input.GetKeyDown(KeyCode.A)) 
//		{
//			printOutList ();
//		}
//

	}

	void TimeList()
	{
		DataList[0] = SecondScriptToAccess.wall_1_timeLooked;
		DataList[1] = SecondScriptToAccess.wall_2_timeLooked;
		DataList[2] = SecondScriptToAccess.wall_3_timeLooked;
		DataList[3] = SecondScriptToAccess.wall_4_timeLooked;
		DataList[4] = SecondScriptToAccess.ball_1_timeLooked;
		DataList[5] = SecondScriptToAccess.ball_2_timeLooked;
		DataList[6] = SecondScriptToAccess.ball_3_timeLooked;
		DataList[7] = SecondScriptToAccess.ball_4_timeLooked;

	}

	void printOutList()
	{
		for (int i = 0; i < 8; i++) {
			Debug.Log (DataList[i]);	
		}

//		foreach(float myValues in DataList)
//		{
//		Debug.Log(myValues);
//		}
	}

	void RankedTextList()
	{
		RankedText.text = newList.ToString();
	}


}
