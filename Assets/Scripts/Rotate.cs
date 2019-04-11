using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float spd = 1.0f;
    public float moveSpd = 0.1f;
    //public Camera cam1;
    //public Camera cam2;
    //private bool flge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0 ,Input.GetAxisRaw("tg")) * moveSpd);

        transform.Rotate(new Vector3(0, Input.GetAxisRaw("fh"),0)*spd);

        //if (Input.GetKeyDown("1")){ flge = !flge; }                     
        //cam2.enabled = !flge;
        //cam1.enabled = flge;


    }
}
