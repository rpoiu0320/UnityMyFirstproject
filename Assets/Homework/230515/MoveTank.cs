using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MoveTank : MonoBehaviour
{
    GameObject gameObject;

    private Vector3 moveDir;        // ������ ��ǥ

    private int movePower = 5;      // ������ ��
    private int rotatePower = 50;   // ȸ���� ��

    void Update()                   // �� �����Ӹ��� ������ ��ġ ���
    {
        Move();
        Rotation();
    }

    private void Move()             // transform�� �̿��Ͽ� ���� ��ǥ�� �����̵���Ű�� ����
    {
        transform.Translate(Vector3.forward * moveDir.z * movePower * Time.deltaTime, Space.Self);
    }   //                                                              �ð���,        �ش� ������Ʈ ����

    private void Rotation()         // Rotate�� ȸ����(�ٶ�) ���� ����
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
