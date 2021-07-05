using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject HPGauge;
    void Start()
    {
        HPGauge = GameObject.Find("HPGauge");
    }

    public void DecreaseHP()
    {
        HPGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    void Update()
    {
        
    }
}
