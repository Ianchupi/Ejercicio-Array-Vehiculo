using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculosManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Vehiculo vehiculoScript;
    
    
    void Start()
    {
        int numRuedas = vehiculoScript.cantRuedas;
        Debug.Log("cantidad ruedas: " + numRuedas);

        if (numRuedas < 6)
        {
            vehiculoScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
