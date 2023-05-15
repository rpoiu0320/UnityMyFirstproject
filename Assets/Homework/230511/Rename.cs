using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rename : MonoBehaviour
{
    public string name;

    private void Awake()
    {
        Debug.Log("Rename Player");
        name = "player";
    }
}
