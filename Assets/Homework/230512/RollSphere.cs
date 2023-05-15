using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollSphere : MonoBehaviour
{
    private Vector3 moveDir;                    // 움직일 좌표
    private Rigidbody rb;                       // 리지드바디

    public Vector3 jumpPower = Vector3.up * 5;  // 점프 힘
    private float movePower = 3;                // 움직일 힘

    private void Update()
    {
        Move();                                 // 업데이트에 무브 넣어서 매 프레임마다 좌표 이동
    }

    private void Move()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(moveDir * movePower, ForceMode.Force);  // 서서히 증가하는 힘으로 moveDir의 위치로 이동
    }

    private void OnMove(InputValue value)       // 입력값을 inputSystem 으로 받음
    {
        moveDir.x = value.Get<Vector2>().x;     // x, z 좌표가 입력값이 있으면 변경됨
        moveDir.z = value.Get<Vector2>().y;
    }

    private void Jump()
    {
        rb = GetComponent<Rigidbody>();         
        rb.AddForce(jumpPower, ForceMode.Impulse);  // 한번에 가해지는 힘으로 좌표를 Vector3.up 으로 이동
    }

    private void OnJump(InputValue value)       // 입력값을 inputSystem 으로 받아서 Space이면 동작
    {
        bool isPress = value.isPressed;         
        Jump();
    }
}
