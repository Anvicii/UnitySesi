using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questao2 : MonoBehaviour
{
    public double lata;
    public double garrafa600;
    public double garrafa2;
    double litros;
    // Start is called before the first frame update
    void Start()
    {
        litros = (lata * 0.35) + (garrafa600 * 0.600) + (garrafa2 * 2);
        Debug.Log(litros);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
