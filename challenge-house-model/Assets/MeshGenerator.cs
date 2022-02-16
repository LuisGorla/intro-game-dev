using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    public Material mat;
    float width = 1;
    float height = 1;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[3];

        vertices[0] = new Vector3(0, 1, 0);
        vertices[1] = new Vector3(-1, 0, 0);
        vertices[2] = new Vector3(1, 0, 0);


        mesh.vertices = vertices;

        mesh.triangles = new int[] { 0, 1, 2};

        GetComponent<MeshRenderer>().material = mat;

        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
