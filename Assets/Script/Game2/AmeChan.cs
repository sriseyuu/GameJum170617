using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeChan : MonoBehaviour
{

	public float speed;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(0.1f, -1.0f, 0.0f) * speed * Time.deltaTime;
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "kasa")
		{
			if (col.GetComponent<Kasa>().open)
			{
				col.gameObject.GetComponent<HPCon>().hp--;
				Destroy(gameObject);
			}
			else
			{
				GameObject.Find("player").GetComponent<HPCon>().hp--;
			}
		}
		else if (col.tag == "Player")
		{
			col.gameObject.GetComponent<HPCon>().hp--;
			Destroy(gameObject);
		}
		else if (col.tag == "Plate")
		{
			Destroy(gameObject);
		}
	}
}
