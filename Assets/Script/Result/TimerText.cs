using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{

	private Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		text.text = "Time:" + PlayerPrefs.GetFloat("Time").ToString("F2");
	}

	// Update is called once per frame
	void Update()
	{

	}
}
