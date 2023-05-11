using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rename : MonoBehaviour
{
    public string name;

    private void Awake()
    {
        name = "player";
        Debug.Log("Rename Player");
    }
}
