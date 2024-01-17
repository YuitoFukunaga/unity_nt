using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0,cam.transform.localEulerAngles.y,0);
        //transform.position += transform.forward;

        if(Input.GetKey(KeyCode.W)) {
            transform.position+=transform.forward;
        }
    }
}
