using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]                       // rigidbody를 반드시 가지도록 해줌

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpped;             // bullet의 움직일 속도

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

    private void OnCollisionEnter(Collision collision)      // bullet의 충동을 체크
    {
        if (collision.gameObject)                           // 만약 충돌한다면
        {
            Destroy(gameObject);                            // bullet 삭제
        }
    }
}
