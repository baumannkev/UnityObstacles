using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public GameObject plane;
    public float intervalTime = 2.0f;
    public float timeStart = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        plane.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart > 2)
        {
            plane.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        
    }
}
