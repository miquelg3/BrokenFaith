using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    private KeyCode Adelante = KeyCode.UpArrow;
    private KeyCode Atras = KeyCode.DownArrow;
    private KeyCode Derecha = KeyCode.RightArrow;
    private KeyCode Izquierda = KeyCode.LeftArrow;
    private KeyCode Shift = KeyCode.LeftShift;
    private bool correr = false;
    private float yaw, pitch;
    public float SpeedH, SpeedV;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Adelante))
        {
            MoverAdelante();
        }
        if (Input.GetKeyDown(Atras))
        {
            MoverAtras();
        }
        if (Input.GetKeyDown(Derecha))
        {
            MoverDerecha();
        }
        if (Input.GetKeyDown(Izquierda))
        {
            MoverIzquierda();
        }
        if (Input.GetKeyDown(Shift))
        {
            correr = true;
        }
        if (Input.GetKeyUp(Shift))
        {
            correr = false;
        }

        yaw += SpeedH * Input.GetAxis("Mouse X");
        pitch += SpeedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(-pitch, yaw, 0f);
    }
    private void MoverAdelante()
    {
        Camera cam = Camera.main;
        Vector3 mover;
        if (correr)
        {
            mover = new(cam.transform.position.x + 2, cam.transform.position.y, cam.transform.position.z);
        }
        else
        {
            mover = new(cam.transform.position.x + 1, cam.transform.position.y, cam.transform.position.z);
        }
        cam.transform.position = mover;
    }
    private void MoverAtras()
    {
        Camera cam = Camera.main;
        Vector3 mover;
        if (correr)
        {
            mover = new(cam.transform.position.x - 2, cam.transform.position.y, cam.transform.position.z);
        }
        else
        {
            mover = new(cam.transform.position.x - 1, cam.transform.position.y, cam.transform.position.z);
        }
        cam.transform.position = mover;
    }
    private void MoverDerecha()
    {
        Camera cam = Camera.main;
        Vector3 mover;
        if (correr)
        {
            mover = new(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 2);
        }
        else
        {
            mover = new(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 1);
        }
        cam.transform.position = mover;
    }
    private void MoverIzquierda()
    {
        Camera cam = Camera.main;
        Vector3 mover;
        if (correr)
        {
            mover = new(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z - 2);
        }
        else
        {
            mover = new(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z - 1);
        }
        cam.transform.position = mover;
    }
}
