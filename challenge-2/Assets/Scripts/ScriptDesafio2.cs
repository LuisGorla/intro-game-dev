using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDesafio2 : MonoBehaviour
{
    int vida = 100;
    float velocidad = 2f;
    Vector3 direcci�n;
    int contadorCuraciones = 0;
    int contadorDa�os = 0;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Presione A,W,S,D para mover el objeto");
        Vector3 direcci�n = transform.position;

        

        if (Input.GetKey("w"))
        {
            Debug.Log("Moviendo el objeto hacia adelante");
            direcci�n.z += velocidad * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            Debug.Log("Moviendo el objeto hacia atras");
            direcci�n.z -= velocidad * Time.deltaTime;
            Da�ar();

            if (vida == 10)
            {
                Curar();
            }
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("Moviendo el objeto hacia la derecha");
            direcci�n.x += velocidad * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("Moviendo el objeto hacia la izquierda");
            direcci�n.x -= velocidad * Time.deltaTime;
        }

        transform.position = direcci�n;


    }

    void Curar()
    {
        vida = 100;
        contadorCuraciones++;
        Debug.Log("Curando...");

    }

    void Da�ar()
    {
        vida -= 10;
        contadorDa�os++;
        Debug.Log("Vida actual: " + vida);
    }
}
