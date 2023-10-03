using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0f, z) * speed * Time.deltaTime;
    }

    public void moveToTeleport()
    {
        player.transform.position = new Vector3(5, 0, 0);
    }
}
