using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ����Ƽ�� �̱���
    private static GameManager instance;
    public static DataManager dataManager;

    public static GameManager Instance{ get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    private void Awake()            // ���� �� �ϳ��� �����ϵ���, �ٸ� instance�� �����Ѵٸ� ����
    {
        if(instance != null)        // �̹� �����Ѵٸ�
        {
            Destroy(this);          // �ش� �ν��Ͻ� ����
            return;
        }
                                    // �ν��Ͻ��� ���� ���ٸ�
        DontDestroyOnLoad(this);    // ���� �ٲ� �����ֵ���
        instance = this;            
        InitManager();
    }

    private void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }

    private void InitManager()
    {
        // DataManager init
        GameObject dataObj = new GameObject() { name = "DataManager" };     // ������ DataManager�� ������
        dataObj.transform.SetParent(transform);                             // dataObj�� �ڽ����� ����
        dataManager = dataObj.AddComponent<DataManager>();                  // dataManager�� �߰�
    }
}