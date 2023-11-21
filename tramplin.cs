using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class tramplin : MonoBehaviour
{
    public float jumpFactor = 2.5f;
   private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>(). jumpStrength*=jumpFactor ;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}
