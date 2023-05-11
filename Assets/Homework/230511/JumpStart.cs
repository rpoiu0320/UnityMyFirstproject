using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 jumpPower = Vector3.up * 5;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(jumpPower, ForceMode.Impulse);

    }
}
