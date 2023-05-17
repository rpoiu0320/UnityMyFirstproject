using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Cinemachine.CinemachineVirtualCamera camera1stPerson;
    [SerializeField] private Cinemachine.CinemachineVirtualCamera camera3rdPerson;

    private void OnChangeCamera(InputValue value)
    {
        if (value.isPressed)                                                          
        {
            camera1stPerson.Priority += 10;
        }
        else                                                                           
        {
            camera1stPerson.Priority -= 10;
        }
    }
}
