using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_planetas : MonoBehaviour
{
    public float Velocidad;
    public GameObject ObjDebajo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.y <= -11)
        {
            transform.position = ObjDebajo.transform.position + new Vector3(0, 11, 0);
        }


        transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);

      
        
    }
}
