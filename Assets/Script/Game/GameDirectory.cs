using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirectory : MonoBehaviour {
    public GameObject candyPrefab;
	// Use this for initialization
	void Start () {
        Screen.fullScreen = !Screen.fullScreen;
        Screen.SetResolution(1024, 768, Screen.fullScreen);

    }
	
	// Update is called once per frame
	void Update () {
        Instantiate(candyPrefab);
        candyPrefab.transform.position = new Vector3(Random.Range(-100,150) / 10.0f,10,5);
	}
}
