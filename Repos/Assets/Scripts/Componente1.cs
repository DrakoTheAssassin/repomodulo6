using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{

    public static GameObject MiObjeto;
    void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        MiObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
