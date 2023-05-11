using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpStart : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 jumpPower = Vector3.up * 5;

    public void Start()
    {
        Debug.Log("JumpStart");
        rb = GetComponent<Rigidbody>();
        rb.AddForce(jumpPower, ForceMode.Impulse);
    }
}
