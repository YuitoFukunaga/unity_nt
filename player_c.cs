using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_c : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");

        float my = Input.GetAxis("Mouse Y");



        if(Mathf.Abs(mx)>0.001f) {

            transform.RotateAround(player.transform.position,Vector3.up,mx);

        }


        if(Input.GetKey(KeyCode.W)) {
            transform.position+=transform.forward;
        }
    }
}
