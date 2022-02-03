using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    public void Cam1()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    public void Cam2()
    {
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
    }

    public void Cam3()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cam1();
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cam2();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Cam3();
        }
    }
}
