using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MoveTank : MonoBehaviour
{
    GameObject gameObject;

    private Vector3 moveDir;        // 움직일 좌표

    private int movePower = 5;      // 움직일 힘
    private int rotatePower = 50;   // 회전할 힘

    void Update()                   // 매 프레임마다 각도와 위치 계산
    {
        Move();
        Rotation();
    }

    private void Move()             // transform을 이용하여 다음 좌표로 순간이동시키는 개념
    {
        transform.Translate(Vector3.forward * moveDir.z * movePower * Time.deltaTime, Space.Self);
    }   //                                                              시간값,        해당 오브젝트 기준

    private void Rotation()         // Rotate로 회전할(바라볼) 각을 지정
    {
        transform.Rotate(Vector3.up * moveDir.x * rotatePower * Time.deltaTime);
        // transform.rotation = Quaternion.Euler(0, moveDir.x , moveDir.y);
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
