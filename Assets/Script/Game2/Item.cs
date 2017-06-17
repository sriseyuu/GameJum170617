using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

	private bool canEquip = false;
	public GameObject kasa;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Kasa") == null)
		{
			var kasaTemp = Instantiate(kasa, Vector3.zero, Quaternion.identity);
			kasaTemp.transform.parent = GameObject.Find("player").transform;
			kasaTemp.transform.position = GameObject.Find("player").transform.position + new Vector3(0.0f, 2.0f, 0.0f);
			Destroy(gameObject);

		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			canEquip = true;
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			canEquip = false;
		}
	}
}
