using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class FireButton : MonoBehaviour
{
    [Header("Shooter")]
    [SerializeField] private Transform bulletPoint;                                        // bullet�� ������ �� �������� �� ��ġ
    [SerializeField] private Bullet0516 bulletPrefab;                                      // ������ bullet�� prefab
    [SerializeField] private AudioSource sootSound;                                        // ����� ����
    [SerializeField] private Animator movingTurret;
    [SerializeField] private GameObject tankTurret;

    public void Fire()
    {
        //movingTurret;
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // ������ ������Ʈ, ��ǥ, ������ ���� 
        sootSound.Play();                                                              // ������ ���� ���
    }
}
