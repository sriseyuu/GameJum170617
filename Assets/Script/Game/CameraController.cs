using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        if (-15.0f < player.transform.position.x && player.transform.position.x < 16.5f)
        {

            transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
	}
}
