using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollSphere : MonoBehaviour
{
    private Vector3 moveDir;                    // ������ ��ǥ
    private Rigidbody rb;                       // ������ٵ�

    public Vector3 jumpPower = Vector3.up * 5;  // ���� ��
    private float movePower = 3;                // ������ ��

    private void Update()
    {
        Move();                                 // ������Ʈ�� ���� �־ �� �����Ӹ��� ��ǥ �̵�
    }

    private void Move()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(moveDir * movePower, ForceMode.Force);  // ������ �����ϴ� ������ moveDir�� ��ġ�� �̵�
    }

    private void OnMove(InputValue value)       // �Է°��� inputSystem ���� ����
    {
        moveDir.x = value.Get<Vector2>().x;     // x, z ��ǥ�� �Է°��� ������ �����
        moveDir.z = value.Get<Vector2>().y;
    }

    private void Jump()
    {
        rb = GetComponent<Rigidbody>();         
        rb.AddForce(jumpPower, ForceMode.Impulse);  // �ѹ��� �������� ������ ��ǥ�� Vector3.up ���� �̵�
    }

    private void OnJump(InputValue value)       // �Է°��� inputSystem ���� �޾Ƽ� Space�̸� ����
    {
        bool isPress = value.isPressed;         
        Jump();
    }
}
