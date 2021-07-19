using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_bala : MonoBehaviour
{
    public float Velocidad;
    //Funcion que cada que pasen 5 segundos la bala se destruira
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Se crea un vector, el cual su velocidad depende del tiempo y ademas se le agrega la posicion a la bala
    
    void Update()
    {
        transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);
    }


    //Si la bala choca con la nave le restara una vida al enemigo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemigo")
        {
            collision.gameObject.GetComponentInParent<Scr_enemigo>().Vida -= 1;
            Destroy(gameObject);
            
        }

    }
}
