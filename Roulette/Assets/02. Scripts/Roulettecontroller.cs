using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float rotSpeed = 0;
    bool isSlow = false; 

    void Start()
    {
        transform.Rotate(0, 0, Random.Range(0f, 360f));
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정
        if (Input.GetMouseButtonDown(0) && rotSpeed == 0f)
        {
            rotSpeed = Random.Range(10.0f, 30.0f);
            isSlow = false; 
        }

        if (Input.GetMouseButtonDown(1) && rotSpeed != 0f)
        {
            isSlow = true; 
        }

        if (isSlow) 
        {
            rotSpeed *= 0.997f;
        }

        if (rotSpeed <= 0.001f)
        {
            rotSpeed = 0f;
        }
        else
        {
            transform.Rotate(0, 0, rotSpeed);
        }
    }
}