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
    [SerializeField] private Transform bulletPoint;                                        // bullet이 생성될 시 기준으로 할 위치
    [SerializeField] private Bullet0516 bulletPrefab;                                      // 생성할 bullet의 prefab
    [SerializeField] private AudioSource sootSound;                                        // 사용할 사운드
    [SerializeField] private Animator movingTurret;
    [SerializeField] private GameObject tankTurret;

    public void Fire()
    {
        //movingTurret;
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);         // 지정한 오브젝트, 좌표, 각도에 생성 
        sootSound.Play();                                                              // 지정한 사운드 출력
    }
}
