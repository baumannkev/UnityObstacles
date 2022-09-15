using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerDetector : MonoBehaviour
{
    public string HitMessage = "Hit trigger!";
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(HitMessage);
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}