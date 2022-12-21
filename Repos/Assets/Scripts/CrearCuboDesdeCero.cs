using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDesdeCero : MonoBehaviour
{

    GameObject ObjetoSpawn;
    Vector3[] vertices =
    {
        new Vector3(0, 0, 0), //vertice0
        new Vector3(1, 0, 0),
        new Vector3(1, 1, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, 1, 1),
        new Vector3(1, 1, 1),
        new Vector3(1, 0, 1),
        new Vector3(0, 0, 1),
    };

    int[] triangulos =
    {
        0,2,1,
        0,3,2,
        2,3,4,
        2,4,5,
        1,2,5,
        1,5,6,
        0,7,4,
        0,4,3,
        5,4,7,
        5,7,6,
        0,6,7,
        0,1,6
    };
    void Start()
    {
        ObjetoSpawn = new GameObject("Nuestro Primer Cubo");
        ObjetoSpawn.AddComponent<MeshFilter>();
        var meshFilter = ObjetoSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        ObjetoSpawn.AddComponent<BoxCollider>();
        var boxCollider = ObjetoSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        ObjetoSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterual = ObjetoSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterual.color = Color.white;
        ObjetoSpawn.transform.position = Vector3.one;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
