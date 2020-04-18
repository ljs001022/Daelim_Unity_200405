using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrowPrefab;
    public bool sw = true;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sw)
        {
            delta += Time.deltaTime; // delta라는 변수에 시간이 얼마나 흘렀는지에 대한 시간값
            if (delta > span)
            {
                delta = 0;
                GameObject go = Instantiate(arrowPrefab) as GameObject;
                int px = Random.Range(-6, 7);
                go.transform.position = new Vector3(px, 7, 0);
            }
        }
    }
}
