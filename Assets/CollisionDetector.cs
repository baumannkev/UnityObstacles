using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetector : MonoBehaviour
{
    public string HitMessage = "Hit collider!";
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(HitMessage);
    }
}
