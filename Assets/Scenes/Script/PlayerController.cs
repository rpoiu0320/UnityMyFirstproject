using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveDir;


    [SerializeField]
    private float movePower;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float RotateSpeed;

    private void Update()
    {
        Move();
         Rotate();
        // LookAt();
    }

    private void Move()
    {
        // transform.position += moveDir * Time.deltaTime;
        // x : 1m/s     
        transform.Translate(Vector3.forward * moveDir.z * movePower * Time.deltaTime, Space.Self);
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * RotateSpeed * Time.deltaTime, Space.Self);
    }

    public void LookAt()
    {   // ��ǥ��ġ�� �ٶ󺸴� �������� ȸ��
        transform.LookAt(new Vector3(0, 0, 0));
    }

    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle(���Ϸ�) : 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����

    // ������ ������ �ƴ°��� �߿�

    public void Rotation()
    {
        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity;

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // Quaternion������ Euler���� ��ȯ
        // transform.rotation.ToEulerAngles();
    }

    private void Jump()
    {
       
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }

    private void OnJump(InputValue value)
    {
        Jump();
    }
}
