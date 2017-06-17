using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KasaContorller : MonoBehaviour {
    GameObject player;

    int Defence;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("player");
        transform.position = player.transform.position;
        transform.Translate(new Vector3(0,0.5f,0));

        Defence = 10;
    }

    // Update is called once per frame
    void Update() {
        transform.position = player.transform.position;
        transform.Translate(new Vector3(0, 0.5f, 0));
    }

    private void LateUpdate()
    {
        if(Defence <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        Destroy(collision.gameObject);

        Defence--;
    }

}
