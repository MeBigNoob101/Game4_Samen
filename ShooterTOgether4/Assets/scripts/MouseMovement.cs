using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottemClamp = 90f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //getting mouse
        float mouseX = Input.GetAxis("MouseX") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("MouseY") * mouseSensitivity * Time.deltaTime;

        //rootation around the x axes

        xRotation -= mouseY;

        //clamp rotation
        xRotation = Mathf.Clamp(xRotation, topClamp, bottemClamp);

        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

    }
}
