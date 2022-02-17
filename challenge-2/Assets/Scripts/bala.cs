using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField]
    private float speed = 6f;
    [SerializeField]
    private float damage = 50f;
    [SerializeField]
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 4f);
        //transform.position += direction * speed * Time.deltaTime;
    }
}
