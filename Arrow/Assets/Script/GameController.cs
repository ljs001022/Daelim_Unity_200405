using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    GameObject hpGauge;
    GameObject Player;
    GameObject Generator;
    int GG = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("HP");
        this.Player = GameObject.Find("player");
        Generator = GameObject.Find("GameObject");
    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
        if(++GG>=5)
        {
            this.Player.SetActive(false);
            Generator.GetComponent<ArrowGenerator>().sw = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
