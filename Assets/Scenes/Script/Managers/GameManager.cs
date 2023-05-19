using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 유니티용 싱글톤
    private static GameManager instance;
    public static DataManager dataManager;

    public static GameManager Instance{ get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    private void Awake()            // 시작 시 하나만 존재하도록, 다른 instance가 존재한다면 삭제
    {
        if(instance != null)        // 이미 존재한다면
        {
            Destroy(this);          // 해당 인스턴스 삭제
            return;
        }
                                    // 인스턴스가 아직 없다면
        DontDestroyOnLoad(this);    // 씬이 바뀌어도 남아있도록
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
        GameObject dataObj = new GameObject() { name = "DataManager" };     // 생성될 DataManager를 가져옴
        dataObj.transform.SetParent(transform);                             // dataObj를 자식으로 설정
        dataManager = dataObj.AddComponent<DataManager>();                  // dataManager를 추가
    }
}