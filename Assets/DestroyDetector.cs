using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDetector : MonoBehaviour
{
    private float waitTime = 2.0f;
    private float timer = 0.0f;
    public string HitMessage = "Hit destroy!";
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
            timer += Time.deltaTime;
            Debug.Log(HitMessage);
            if (timer > waitTime) {
            Destroy(other.gameObject);
        }
    }

    private void Start()
    {
        timer = 0.0f;
    }

    private void Update()
    {
        
    }
}
