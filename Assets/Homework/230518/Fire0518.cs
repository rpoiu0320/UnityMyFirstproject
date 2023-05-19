using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class Fire0518 : MonoBehaviour
{
    [Header("Shooter")]
    [SerializeField] private Transform bulletPoint;                                        // bullet�� ������ �� �������� �� ��ġ
    [SerializeField] private Bullet0516 bulletPrefab;                                      // ������ bullet�� prefab
    [SerializeField] private float repeatTime;                                             // ��߻� �ñ��� �ɸ� �ð�

    public UnityEvent OnFired;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /*private void OnEnable()
    {
        GameManager.Data.OnShootCount.AddListener(Test);
    }*/

    IEnumerator BulletMakeRoutine()                                                        // �ڷ�ƾ ���� ����
    {
        while (true)
        {
            GameManager.Data.AddShottCount(1);
            animator.SetTrigger("Fire");                                                   // Animator�� Parameters�� �ִ� Fire�� �۵���Ŵ
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // ������ ������Ʈ, ��ǥ, ������ ����                                                            // ������ ���� ���
            OnFired?.Invoke();
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
