using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    Animator animator;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        // 점프한다
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        
        /*
        // 스마트폰에서의 점프
        if (Input.GetMouseButtonDown(0) && rigid2D.velocity.y == 0)
        {
            animator.SetTrigger("JumpTrigger");
            rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // // 스마트폰에서의 좌우 이동
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;
        */

        // 플레이어 속도
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        // 스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        // 움직이는 방향에 따라 이미지 반전
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        //animator.speed = speedx / 2.0f;
        if (rigid2D.velocity.y == 0)
            animator.speed = speedx / 2.0f;
        else
            animator.speed = 1.0f;
        if (transform.position.y < -10)
            SceneManager.LoadScene("SampleScene");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("깃발 충돌");
        SceneManager.LoadScene("ClearScene");
    }
}