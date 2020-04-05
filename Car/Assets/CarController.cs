using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0)) // 마우스를 클릭하면
        {
            this.speed = 0.2f; // 처음 속도를 설정
        }*/
        // 스와이프의 길이를 구한다
        if(Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스를 뗴었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipelength = endPos.x - this.startPos.x;

            // 스와이프 길이를 처음 속도롤 변경한다
            this.speed = swipelength / 500.0f;

            // 효과음을 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); // 이동
        this.speed *= 0.98f; // 감속
    }
}
