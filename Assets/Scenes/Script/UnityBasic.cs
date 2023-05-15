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
        // <���ӿ�����Ʈ ����>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        // thisGameObject = gameObject;                // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ

        // gameObject.name;                         // ���ӿ�����Ʈ�� �̸� ����
        // gameObject.activeSelf;                   // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.tag;                          // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;                        // ���ӿ�����Ʈ�� ���̾� ����

        // <�� ���� ���ӿ�����Ʈ Ž��>
        // GameObject.Find("Player");                   // �̸����� ã��
        // GameObject.FindGameObjectWithTag("Player");  // �±׷� �ϳ� ã��
        // GameObject.FindGameObjectsWithTag("MyTag");  // �±׷� ��� ã�� (Hierarchy���� ���������� ã��), �迭

        // <���ӿ�����Ʈ ����>
        // GameObject newGameObject = new GameObject();
        // newGameObject.name = "New Game Object";

        // <���ӿ�����Ʈ ����>
        //if (destroyGameObject != null)
        //    Destroy(destroyGameObject, 5f);       // 5�� �� ����
    }

    public void ComponentBasic()
    {
        // <���ӿ�����Ʈ �� ������Ʈ ����>
        // GetComponent�� �̿��Ͽ� ���ӿ�����Ʈ �� ������Ʈ ����
        audioSource = GetComponent<AudioSource>();
        audioSource.GetComponent<AudioSource>();                
        audioSource = gameObject.GetComponent<AudioSource>();
        // ��� ������ ����, ���� ������Ʈ�� �پ��ִ� ������Ʈ
        // ������Ʈ���� GetComponent�� ����� ��� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �������� ����
        GetComponents<AudioSource>();                           // FindGameObjectsWithTag�� �����ϰ� ���� Componet ����, Component���� ���������� ã��

        GetComponentsInChildren<Rigidbody>();                   // �ڽİ��ӿ�����Ʈ�� ���� Component ���� 
        GetComponentInChildren<Rigidbody>();                    // �ڽİ��ӿ�����Ʈ�� ���� ���� Component ����
        gameObject.GetComponentInChildren<Rigidbody>();         // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�� ���� Component ���� 
        gameObject.GetComponentsInChildren<Rigidbody>();        // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�� ���� ���� Component ����

        GetComponentsInParent<Rigidbody>();                     // �θ���ӿ�����Ʈ�� ���� Component ���� 
        GetComponentInParent<Rigidbody>();                      // �θ���ӿ�����Ʈ�� ���� ���� Component ����
        gameObject.GetComponentInParent<Rigidbody>();           // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�� ���� Component ���� 
        gameObject.GetComponentsInParent<Rigidbody>();          // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�� ���� ���� Component ����

        // <������Ʈ Ž��>
        FindObjectOfType<AudioSource>();                        // �� ���� ������Ʈ Ž��
        FindObjectsOfType<AudioSource>();                       // �� ���� ��� ������Ʈ Ž��

        // <������Ʈ �߰�>
        // Rigidbody rigid = new Rigidbody();	                // �����ϳ� �ǹ̾���, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        gameObject.AddComponent<Rigidbody>();                   // ���ӿ�����Ʈ�� ������Ʈ �߰�

        // <������Ʈ ����>
        Destroy(gameObject);
    }
}
