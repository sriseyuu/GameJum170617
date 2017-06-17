using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
	private Rigidbody2D rigid2D2;
	private HPCon hpCon;
	private bool isJump2;
	private float timer = 0.0f;

	// Use this for initialization
	void Start()
	{
		isJump2 = true;
		hpCon = GetComponent<HPCon>();
		rigid2D2 = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (hpCon.hp <= 0)
		{
			PlayerPrefs.SetFloat("Time", timer);
			SceneManager.LoadScene("Scene/ScoreScene");
		}
		if (Input.GetKeyDown(KeyCode.Space) && isJump2 == false)
		{
			rigid2D2.AddForce(new Vector3(0, 200.0f, 0));

			isJump2 = true;
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(0.05f, 0, 0);
			transform.localScale = new Vector3(5, 5, 1);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-0.05f, 0, 0);
			transform.localScale = new Vector3(-5, 5, 1);
		}
		if (transform.position.x >= 17.0f)
			transform.position = new Vector3(-16.9f, transform.position.y, transform.position.z);
		if (transform.position.x <= -17.0f)
			transform.position = new Vector3(16.9f, transform.position.y, transform.position.z);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		isJump2 = false;
	}
}
