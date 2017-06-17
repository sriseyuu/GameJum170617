using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeGene : MonoBehaviour
{

	private float startTimer;
	public GameObject ame;

	// Use this for initialization
	void Start()
	{
		startTimer = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time - startTimer > 0.1f)
		{
			var pPos = GameObject.Find("player").transform.position;
			var sPos = new Vector3(pPos.x + Random.Range(-8.0f, 8.1f), 6.0f);
			Instantiate(ame, sPos, Quaternion.identity);
			startTimer = Time.time;
		}
	}
}
