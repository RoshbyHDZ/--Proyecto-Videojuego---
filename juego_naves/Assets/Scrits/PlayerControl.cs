using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
   

    public Vector3 Movimiento;
    public float Velocidad;
    public GameObject bala;
    public float Timer, TiempoDeEspera;
    public int Puntos;
    public Text Puntuacion;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Controles de la nave
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        Movimiento = Movimiento.normalized;
        transform.position += Movimiento * Velocidad* Time.deltaTime;

        //Disparo de la nave
        if(Input.GetKey("space") && Timer <=0)
        {
            //posicion de la bala y tiempo en que sale
            Instantiate(bala, transform.position, Quaternion.Euler(0, 0, 0));
            Timer = TiempoDeEspera;
        }
        Timer -= Time.deltaTime;

        //Cuenta los puntos
        Puntuacion.text = Puntos.ToString("");
        //Cambia de escena al pasar de 10 puntos
        if (Puntos >= 10)

        {
            //Para pasar de escena
            SceneManager.LoadScene("juego");


        }
    }
    //Se mueres se vuelve a cargar la misma escena
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemigo" )
        {
            SceneManager.LoadScene("juego");
        }

    }


}
