using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bala;
    public Transform ejeDisparo;
    [SerializeField]
    private Vector3 initialVelocity;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {      

        if (Input.GetKeyDown("space"))
        {
            Disparar();
        }
        if(Input.GetKeyDown("j"))
        {           
            Disparar();
        }
        if (Input.GetKeyDown("k"))
        {
            Disparar();
        }
        if (Input.GetKeyDown("l"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(bala, ejeDisparo.position, Quaternion.identity);

        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        rb.AddForce(initialVelocity, ForceMode.Impulse);
    }
}
