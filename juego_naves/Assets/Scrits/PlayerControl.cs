using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   

    public Vector3 Movimiento;
    public float Velocidad;
    public GameObject bala;
    public float Timer, TiempoDeEspera;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        Movimiento = Movimiento.normalized;
        transform.position += Movimiento * Velocidad* Time.deltaTime;

        if(Input.GetKey("space") && Timer <=0)
        {
            Instantiate(bala, transform.position, Quaternion.Euler(0, 0, 90));
            Timer = TiempoDeEspera;
        }
        Timer -= Time.deltaTime;
    }
}
