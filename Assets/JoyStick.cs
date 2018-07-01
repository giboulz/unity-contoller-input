using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour {

    public bool isButton;
    public bool isLeftJoystick;
    public string buttonName; 

    
    private Vector3 startPos;
    private MeshRenderer meshRenderer; 


	// Use this for initialization
	void Start () {
        meshRenderer = GetComponent<MeshRenderer>();
        
        startPos = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
        if (isButton)
        {
            meshRenderer.enabled = Input.GetButton(buttonName); 
        }
        else
        {
            Vector3 inputDirection = Vector3.zero;

            if (isLeftJoystick)
            {
                inputDirection.x = Input.GetAxis("LeftJoystickHorizontal");
                inputDirection.z = Input.GetAxis("LeftJoystickVertical");
            }
            else
            {
                inputDirection.x = Input.GetAxis("RightJoystickHorizontal");
                inputDirection.z = Input.GetAxis("RightJoystickVertical");
            }

            transform.position = startPos + inputDirection; 
        }
	}
}
