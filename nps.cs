using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nps : MonoBehaviour
{
    int zdovie = 5;
    int level = 1;
    public float speed = 1.5f;
    void Start()
    {
        zdovie += level;
        print("здоровье" +  zdovie);
    }

    
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
