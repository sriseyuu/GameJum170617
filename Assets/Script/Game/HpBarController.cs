using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour
{
    Slider _slider;
    // Use this for initialization
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

        _slider.maxValue = PlayerController.Player_MAX_HP;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = PlayerController.Player_HP;
    }
}
