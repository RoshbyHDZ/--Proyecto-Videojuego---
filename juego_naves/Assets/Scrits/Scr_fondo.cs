using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_fondo : MonoBehaviour
{
    Material mt;
    public float paralax = 2f;
    Vector2 offset;

    //Toma el objeto con el que se creo el fondo que es un material
    void Start()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        mt = sp.material;

        offset = mt.mainTextureOffset;

    }

    //Y aca le agrega el efecto parallax, este se aplica mientras va pasando el tiempo
    void Update()
    {

        offset.y += Time.deltaTime / paralax;

        mt.mainTextureOffset = offset; 
       
    }

}
