using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]                       // rigidbody�� �ݵ�� �������� ����

public class Bullet0516 : MonoBehaviour
{
    [SerializeField] private float bulletSpped;             // bullet�� ������ �ӵ�
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private AudioSource destroySound;

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

    private void OnCollisionEnter(Collision collision)      // bullet�� �浹�� üũ
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);                                // bullet ����
        destroySound.Play();
    }
}
