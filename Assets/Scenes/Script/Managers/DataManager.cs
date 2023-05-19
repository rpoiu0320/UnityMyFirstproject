using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField]private int shootCount;

    public UnityEvent<int> OnShootCount;

    public void AddShottCount(int count)
    {
        shootCount += count;
        OnShootCount?.Invoke(shootCount);
    }
}
