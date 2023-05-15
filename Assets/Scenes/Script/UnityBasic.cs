using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    public AudioSource audioSource;

    public void Satrt()
    {
        GameObjectBasic();
        ComponentBasic();
    }

    public void GameObjectBasic()
    {
        // <게임오브젝트 접근>
        // 컴포넌트가 붙어있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능
        // thisGameObject = gameObject;                // 컴포넌트가 붙어있는 게임오브젝트

        // gameObject.name;                         // 게임오브젝트의 이름 접근
        // gameObject.activeSelf;                   // 게임오브젝트의 활성화 여부 접근
        // gameObject.tag;                          // 게임오브젝트의 태그 접근
        // gameObject.layer;                        // 게임오브젝트의 레이어 접근

        // <씬 내의 게임오브젝트 탐색>
        // GameObject.Find("Player");                   // 이름으로 찾기
        // GameObject.FindGameObjectWithTag("Player");  // 태그로 하나 찾기
        // GameObject.FindGameObjectsWithTag("MyTag");  // 태그로 모두 찾기 (Hierarchy에서 위에서부터 찾음), 배열

        // <게임오브젝트 생성>
        // GameObject newGameObject = new GameObject();
        // newGameObject.name = "New Game Object";

        // <게임오브젝트 삭제>
        //if (destroyGameObject != null)
        //    Destroy(destroyGameObject, 5f);       // 5초 뒤 삭제
    }

    public void ComponentBasic()
    {
        // <게임오브젝트 내 컴포넌트 접근>
        // GetComponent를 이용하여 게임오브젝트 내 컴포넌트 접근
        audioSource = GetComponent<AudioSource>();
        audioSource.GetComponent<AudioSource>();                
        audioSource = gameObject.GetComponent<AudioSource>();
        // 모두 동일한 동작, 같은 오브젝트에 붙어있는 컴포넌트
        // 컴포넌트에서 GetComponent를 사용할 경우 부착되어 있는 게임오브젝트를 기준으로 접근
        GetComponents<AudioSource>();                           // FindGameObjectsWithTag와 동일하게 여러 Componet 접근, Component에서 위에서부터 찾음

        GetComponentsInChildren<Rigidbody>();                   // 자식게임오브젝트를 포함 Component 접근 
        GetComponentInChildren<Rigidbody>();                    // 자식게임오브젝트를 포함 여러 Component 접근
        gameObject.GetComponentInChildren<Rigidbody>();         // 게임오브젝트의 자식게임오브젝트를 포함 Component 접근 
        gameObject.GetComponentsInChildren<Rigidbody>();        // 게임오브젝트의 자식게임오브젝트를 포함 여러 Component 접근

        GetComponentsInParent<Rigidbody>();                     // 부모게임오브젝트를 포함 Component 접근 
        GetComponentInParent<Rigidbody>();                      // 부모게임오브젝트를 포함 여러 Component 접근
        gameObject.GetComponentInParent<Rigidbody>();           // 게임오브젝트의 부모게임오브젝트를 포함 Component 접근 
        gameObject.GetComponentsInParent<Rigidbody>();          // 게임오브젝트의 부모게임오브젝트를 포함 여러 Component 접근

        // <컴포넌트 탐색>
        FindObjectOfType<AudioSource>();                        // 씬 내의 컴포넌트 탐색
        FindObjectsOfType<AudioSource>();                       // 씬 내의 모든 컴포넌트 탐색

        // <컴포넌트 추가>
        // Rigidbody rigid = new Rigidbody();	                // 가능하나 의미없음, 컴포넌트는 게임오브젝트에 부착되어 동작함에 의미가 있음
        gameObject.AddComponent<Rigidbody>();                   // 게임오브젝트에 컴포넌트 추가

        // <컴포넌트 삭제>
        Destroy(gameObject);
    }
}
