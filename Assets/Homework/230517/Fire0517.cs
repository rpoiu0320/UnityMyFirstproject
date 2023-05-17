using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class Fire0517 : MonoBehaviour
{
    [Header("Shooter")]
    [SerializeField] private Transform bulletPoint;                                        // bullet이 생성될 시 기준으로 할 위치
    [SerializeField] private Bullet0516 bulletPrefab;                                      // 생성할 bullet의 prefab
    [SerializeField] private float repeatTime;                                             // 재발사 시까지 걸릴 시간
    [SerializeField] private AudioSource sootSound;                                        // 사용할 사운드

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    IEnumerator BulletMakeRoutine()                                                        // 코루틴 동작 지정
    {
        while (true)
        {
            animator.SetTrigger("Fire");                                                   // Animator의 Parameters에 있는 Fire를 작동시킴
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // 지정한 오브젝트, 좌표, 각도에 생성
            sootSound.Play();                                                              // 지정한 사운드 출력
            yield return new WaitForSeconds(repeatTime);                                   // repeatTime만큼의 지연시간을 가진 후 다음 코드로 넘어감   
        }
    }

    private Coroutine bulletRoutine;

    private void OnRepeatFire(InputValue value)                                            // 발사 키를 누르면 동작
    {
        if (value.isPressed)                                                               // 눌린 상태이면
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());                           // 코루틴 동작
        }
        else                                                                               // 키를 때면
        {
            StopCoroutine(bulletRoutine);                                                  // 코루틴 정지
            // yield return new WaitForSecondsRealtime(repeatTime);
        }       
    }
}
