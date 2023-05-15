using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]                       // rigidbody�� �ݵ�� �������� ����

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpped;             // bullet�� ������ �ӵ�

    private Rigidbody rb;           

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                     // �ش� ������Ʈ�� rigidbody�� ���� 
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpped;      // ���ӵ� ���� �̵�
        Destroy(gameObject, 5f);                            // ������ �� 5�� �ĸ� �����
    }

    private void OnCollisionEnter(Collision collision)      // bullet�� �浿�� üũ
    {
        if (collision.gameObject)                           // ���� �浹�Ѵٸ�
        {
            Destroy(gameObject);                            // bullet ����
        }
    }
}
