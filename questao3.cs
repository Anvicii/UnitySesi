using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questao3 : MonoBehaviour
{
    public double n1;
    public double n2;
    public double n3;
    public double na;
    double nf;
    // Start is called before the first frame update
    void Start()
    {
        nf = (n1 + n2 + n3 + na) / 4;
        Debug.Log(nf);

        if (nf >= 9.1 )
        {
            Debug.Log("Conceito A");
        }
        else if (nf >= 7.6)
        {
            Debug.Log("Conceito B");
        }
        else if(nf >=6.1)
        {
            Debug.Log("Conceito c");
        }
        else if(nf >=4.1)
        {
            Debug.Log("Conceito D");
        }
        else
        {
            Debug.Log("Conceito E");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
