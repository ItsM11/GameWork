using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraMovement : MonoBehaviour
{
    //Sensibilidades da Camera
    public float sensX;
    public float sensY;

    public Transform Orientation;

    //Rotação de Camera
    float xRotate;
    float yRotate;

    // Start is called before the first frame update
    void Start()
    {
        //Manter o cursor fixo no centro e invisivel
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Input de Rato
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotate += mouseX;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f); // Impede visão > e > do que 90 Graus

        // Rotação de Camera e Orientação
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        Orientation.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
