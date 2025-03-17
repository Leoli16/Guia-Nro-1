using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{

    int edad;
    float pesoEnKg;
    string nombre;
    bool validoParaElTrabajo;
    
    // Start is called before the first frame update
    void Start()
    {
        edad = 21;
        pesoEnKg = 81.4f;
        nombre = "Gabriel";
        validoParaElTrabajo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
