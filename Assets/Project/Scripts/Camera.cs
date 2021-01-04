using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public float lookSensitivity = 200f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false ;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.visible = true)
            Cursor.visible = false ;
            Cursor.lockState = CursorLockMode.Locked;
        transform.Rotate(Input.GetAxis("Mouse Y")*-1*2,0f,0f * lookSensitivity * Time.deltaTime);
    }
}
