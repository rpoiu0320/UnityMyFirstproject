using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Fire0516 : MonoBehaviour
{
    [Header("Shooter")]
    [SerializeField] private Transform bulletPoint;                                        // bullet�� ������ �� �������� �� ��ġ
    [SerializeField] private Bullet0516 bulletPrefab;                                      // ������ bullet�� prefab
    [SerializeField] private float repeatTime;                                             // ��߻� �ñ��� �ɸ� �ð�

    IEnumerator BulletMakeRoutine()                                                        // �ڷ�ƾ ���� ����
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // ������ ������Ʈ, ��ǥ, ������ ����
            yield return new WaitForSeconds(repeatTime);                                   // repeatTime��ŭ�� �����ð��� ���� �� ���� �ڵ�� �Ѿ   
        }
    }

    private Coroutine bulletRoutine;

    private void OnRepeatFire(InputValue value)                                             // �߻� Ű�� ������ ����
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
