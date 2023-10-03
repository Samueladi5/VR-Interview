using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Head;

    public GameObject UICanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        UICanvas.transform.LookAt(new Vector3 (Head.position.x, UICanvas.transform.position.y, Head.position.z));
        UICanvas.transform.forward *= -1;
    }
}
