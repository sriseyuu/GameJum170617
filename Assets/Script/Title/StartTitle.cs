using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTitle : MonoBehaviour {
	public void PushButton()
    {
        SceneManager.LoadScene("SerectScene");
    }
}
