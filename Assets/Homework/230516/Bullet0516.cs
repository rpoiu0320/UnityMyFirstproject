using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]                       // rigidbody를 반드시 가지도록 해줌

public class Bullet0516 : MonoBehaviour
{
    [SerializeField] private float bulletSpped;             // bullet의 움직일 속도
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private AudioSource destroySound;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                     // 해당 오브젝트의 rigidbody를 지정 
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpped;      // 가속도 없이 이동
        Destroy(gameObject, 5f);                            // 생성된 후 5초 후면 사라짐
    }

    private void OnCollisionEnter(Collision collision)      // bullet의 충돌을 체크
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);                                // bullet 삭제
        destroySound.Play();
    }
}
