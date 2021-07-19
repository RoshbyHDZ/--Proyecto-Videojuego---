using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_enemySpawner : MonoBehaviour
{
    public GameObject Enemigo;
    public float Timer, TiempoEspera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tiempo para que vuelva a cargar el enemigo
        if (Timer <= 0)
        {
            Instantiate(Enemigo, new Vector3(0,0,0),Quaternion.Euler(0,0,0));
            Timer = TiempoEspera;
        }
        Timer -= Time.deltaTime;
        
    }
}
