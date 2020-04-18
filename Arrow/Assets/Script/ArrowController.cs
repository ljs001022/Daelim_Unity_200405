﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킨다
        transform.Translate(0, -0.1f, 0);

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다
        if(transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
}
