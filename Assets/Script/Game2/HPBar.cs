using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
	private Slider slider;
	// Use this for initialization
	void Start()
	{
		slider = GameObject.Find("Slider").GetComponent<Slider>();
	}

	// Update is called once per frame
	void Update()
	{
		slider.maxValue = GameObject.Find("player").GetComponent<HPCon>().maxHP;
		slider.value = GameObject.Find("player").GetComponent<HPCon>().hp;
	}
}
