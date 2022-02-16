using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDesafio2 : MonoBehaviour
{
    int vida = 100;
    float velocidad = 2f;
    Vector3 dirección;
    int contadorCuraciones = 0;
    int contadorDaños = 0;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Presione A,W,S,D para mover el objeto");
        Vector3 dirección = transform.position;

        

        if (Input.GetKey("w"))
        {
            Debug.Log("Moviendo el objeto hacia adelante");
            dirección.z += velocidad * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            Debug.Log("Moviendo el objeto hacia atras");
            dirección.z -= velocidad * Time.deltaTime;
            Dañar();

            if (vida == 10)
            {
                Curar();
            }
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("Moviendo el objeto hacia la derecha");
            dirección.x += velocidad * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("Moviendo el objeto hacia la izquierda");
            dirección.x -= velocidad * Time.deltaTime;
        }

        transform.position = dirección;


    }

    void Curar()
    {
        vida = 100;
        contadorCuraciones++;
        Debug.Log("Curando...");

    }

    void Dañar()
    {
        vida -= 10;
        contadorDaños++;
        Debug.Log("Vida actual: " + vida);
    }
}
