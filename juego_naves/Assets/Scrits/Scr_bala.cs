using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_bala : MonoBehaviour
{
    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);
    }
}
