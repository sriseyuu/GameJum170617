using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rigid2D;

    bool isJump;

	// Use this for initialization
	void Start () {
        isJump = true;

        rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            rigid2D.AddForce(new Vector3(0,200.0f,0));

            isJump = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.05f,0,0);
            transform.localScale = new Vector3(5, 5, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0, 0);
            transform.localScale = new Vector3(-5, 5, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;
    }
}
