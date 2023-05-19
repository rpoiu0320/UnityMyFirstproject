using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting // : MonoBehaviour ����
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)] // ��� ������ �����ϵ� �������ڸ��� ȣ��Ǵ� �Լ�

    private static void Init()  // ���� �����ϱ� �� �ʿ��� ������ ��) ������, ����, Inventory ��
    {
        if(GameManager.Instance == null)    // Gamemanager�� �ν��Ͻ��� ������
        {
            GameObject gameManager = new GameObject() { name = "GameManager" }; // Gamemanager�� �ҷ�����
            gameManager.AddComponent<GameManager>();                            // Gamemanager ����
        }
    }
}