using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera Maincamera;
    public Camera camera2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Maincamera.enabled = true;
        camera2.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (Maincamera) 
        {
            Maincamera.enabled=false;
            camera2.enabled=true;
        }

    }
}
