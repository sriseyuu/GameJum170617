using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kasa : MonoBehaviour
{

	private HPCon hpCon;
	public bool open = true;
	private AudioSource closeSE;
	private AudioSource openSE;
	private AudioSource getSE;

	// Use this for initialization
	void Start()
	{
		hpCon = GetComponent<HPCon>();
		transform.localScale = new Vector3(0.4f, 0.2f, 0.1f);
		AudioSource[] audioSources = GetComponents<AudioSource>();
		closeSE = audioSources[0];
		openSE = audioSources[1];
		getSE = audioSources[2];
		getSE.Play();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			open = !open;
			if (open) openSE.Play();
			else closeSE.Play();
		}
		if (hpCon.hp <= 0)
			Destroy(gameObject);
	}
}
