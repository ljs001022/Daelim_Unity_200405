using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isTouch = false;
    public GameObject blockPrefab;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            isTouch = true;
            Instantiate(blockPrefab);
        }
    }
}