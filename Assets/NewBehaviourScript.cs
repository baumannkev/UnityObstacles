using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public float x = 0.0f;
    public float y = 3.25f;
    public float z = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // The player
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = player.transform.position + new Vector3(x, y, z);
    }
}
