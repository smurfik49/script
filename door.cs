using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class door : MonoBehaviour
{
    public static bool DoorKey;
    public bool open;
    public bool cloce;
    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    void Update()
    {
        if (inTrigger)
        {
            if (cloce)
            {
                if (DoorKey)
                {
                    if (UnityEngine.Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        cloce = false;
                    }
                }



            }
            else
            {
                if (UnityEngine.Input.GetKeyDown(KeyCode.E))
                {
                    cloce = true;
                    open = false;
                }

            }
            if (inTrigger)
            {
                if (open)
                {
                    var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                    transform.rotation = newRot;
                }
                else
                {
                    var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
                    transform.rotation = newRot;
                }
            }
        }
        void OnGUI()
        {
            if (inTrigger)
            {
                if (open)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to cloce");
                }
                else
                {
                    if (DoorKey)
                    {
                        GUI.Box(new Rect(0, 0, 200, 25), "Press E to open");
                    }
                    else
                    {
                        GUI.Box(new Rect(0, 0, 200, 25), "Need a Key");
                    }

                }
            }
        }
    }
}
