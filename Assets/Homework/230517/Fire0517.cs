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
    [SerializeField] private Transform bulletPoint;                                        // bullet�� ������ �� �������� �� ��ġ
    [SerializeField] private Bullet0516 bulletPrefab;                                      // ������ bullet�� prefab
    [SerializeField] private float repeatTime;                                             // ��߻� �ñ��� �ɸ� �ð�
    [SerializeField] private AudioSource sootSound;                                        // ����� ����

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    IEnumerator BulletMakeRoutine()                                                        // �ڷ�ƾ ���� ����
    {
        while (true)
        {
            animator.SetTrigger("Fire");                                                   // Animator�� Parameters�� �ִ� Fire�� �۵���Ŵ
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // ������ ������Ʈ, ��ǥ, ������ ����
            sootSound.Play();                                                              // ������ ���� ���
            yield return new WaitForSeconds(repeatTime);                                   // repeatTime��ŭ�� �����ð��� ���� �� ���� �ڵ�� �Ѿ   
        }
    }

    private Coroutine bulletRoutine;

    private void OnRepeatFire(InputValue value)                                            // �߻� Ű�� ������ ����
    {
        if (value.isPressed)                                                               // ���� �����̸�
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());                           // �ڷ�ƾ ����
        }
        else                                                                               // Ű�� ����
        {
            StopCoroutine(bulletRoutine);                                                  // �ڷ�ƾ ����
            // yield return new WaitForSecondsRealtime(repeatTime);
        }       
    }
}
