using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private CinemachineCameraOffset camera1stPerson;
    [SerializeField] private CinemachineCameraOffset camera3rdPerson;

    private void OnChangeCamera(InputValue value)
    {
        if (value.isPressed)                                                          
        {
            
        }
        else                                                                            
        {
            
        }
    }
}
