using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rigid2D;

    public AudioClip kasaOpenSE;
    public AudioClip kasaCloseSE;

    AudioSource aud;

    bool isJump;

    public static int Player_MAX_HP;
    public static int Player_HP;

    GameObject kasa;

	// Use this for initialization
	void Start () {

        transform.position = new Vector3(-14.9f,0,0);
        isJump = true;

        rigid2D = GetComponent<Rigidbody2D>();

        Player_MAX_HP = 100;
        Player_HP = Player_MAX_HP;

        kasa = GameObject.Find("kasa");

        aud = GetComponent<AudioSource>();
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
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0, 0);
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(kasa != null)
            {
                if (kasa.activeSelf)
                {
                    kasa.SetActive(false);

                    aud.PlayOneShot(kasaCloseSE);
                }
                else
                {
                    kasa.SetActive(true);
                    aud.PlayOneShot(kasaOpenSE);
                }
            }
        }
    }

    private void LateUpdate()
    {
        if(Player_HP <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "candy")
        {
            Player_HP -= 10;
        }
        if (collision.gameObject.tag == "Road")
        {
            isJump = false;
        }
    }
}
