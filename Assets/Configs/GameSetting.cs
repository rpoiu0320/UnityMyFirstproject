using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting // : MonoBehaviour 삭제
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)] // 어느 씬에서 시작하든 시작하자마자 호출되는 함수

    private static void Init()  // 게임 시작하기 전 필요한 설정들 예) 프레임, 볼륨, Inventory 등
    {
        if(GameManager.Instance == null)    // Gamemanager의 인스턴스가 없으면
        {
            GameObject gameManager = new GameObject() { name = "GameManager" }; // Gamemanager를 불러오고
            gameManager.AddComponent<GameManager>();                            // Gamemanager 생성
        }
    }
}