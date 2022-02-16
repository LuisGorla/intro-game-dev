using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoGutierrez : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector3(1,1,0);
        transform.localScale = new Vector3(1, 1, 1);

    }


    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.position += new Vector3(0.25f * Time.deltaTime, 0, 0);

        
        transform.localScale += new Vector3(0, 0.25f * Time.deltaTime, 0);
        
    }


}
