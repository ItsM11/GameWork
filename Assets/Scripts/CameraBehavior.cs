using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Camera WideAngleCamera;
    public Camera MediumCamera;
    public Camera CloseUpCamera;
    public Camera OrthographicCamera;
    public Camera MainCamera;

    public float FieldOfViewDeafult = 70f;
    public float FieldOfViewZoomPlus = 30f;
    public float FieldOfViewZoomMinus = 120f;

    // Start is called before the first frame update
    void Start()
    {
        AtivarCamera(WideAngleCamera);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AtivarCamera(WideAngleCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            AtivarCamera(WideAngleCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AtivarCamera(MediumCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            AtivarCamera(MediumCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AtivarCamera(CloseUpCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            AtivarCamera(CloseUpCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AtivarCamera(OrthographicCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            AtivarCamera(OrthographicCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AtivarCamera(MainCamera);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            AtivarCamera(MainCamera);
        }


        if (MediumCamera.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                AtivarCamera(MediumCamera);

                MediumCamera.fieldOfView =  FieldOfViewZoomMinus;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                AtivarCamera(MediumCamera);

                MediumCamera.fieldOfView = FieldOfViewZoomPlus;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                AtivarCamera(MediumCamera);

                MediumCamera.fieldOfView =  FieldOfViewDeafult;
            }
        }
    }

    void AtivarCamera(Camera cameraAtiva)
    {
        //Desativar Cameras
        WideAngleCamera.enabled = false;
        MediumCamera.enabled = false;
        CloseUpCamera.enabled = false;
        OrthographicCamera.enabled = false;

        //Ativar Camera Preferida
        cameraAtiva.enabled = true;
    }

     

}

