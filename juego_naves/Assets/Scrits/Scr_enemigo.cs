using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_enemigo : MonoBehaviour
{
    public float VelocidadRotacion;
    public float VelocidadBajada;
    public GameObject Enemigo;

    public int Vida;
    public int RandomScale;

    //Da la posicion se mueve el enemigo
    void Start()
    {
        if(Random.Range(0,2) == 0)
        {
            RandomScale = 1;

        }
        else
        {
            RandomScale = -1;
        }

        transform.localScale = new Vector3(RandomScale, 1, 1);
    }

    // Le da la velocidad para que el enemigo rote de izquierda a derecha o viceversa
    void Update()
    {
        Enemigo.transform.Rotate(0, 0, VelocidadRotacion * Time.deltaTime);
        transform.position += new Vector3(0, VelocidadBajada * Time.deltaTime, 0);

        //si se destruye un enemigo se gana 1 punto
        if (Vida <= 0)
        {
            GameObject.Find("Jugador1").GetComponent<PlayerControl>().Puntos += 1; 
            Destroy(gameObject);
        }
    }

   
}
