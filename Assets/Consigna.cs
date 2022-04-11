using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna : MonoBehaviour
{
    public string nombre;
    public int año;
    public string especialidad;

    string T;
    string G;
    string H;
    string D;
    string M;
    // Start is called before the first frame update
    void Start()
    {

        if (true)
        {
            if (año<3)
            {
                Debug.Log("Error, aun estas en ciclo basico");
            }
            if (especialidad != T)
            {
                Debug.Log("Solo se puede ingresar T, G, H, D o M");
            }
            if (especialidad != G)
            {
                Debug.Log("Solo se puede ingresar T, G, H, D o M");
            }
            if (especialidad != H)
            {
                Debug.Log("Solo se puede ingresar T, G, H, D o M");
            }
            if (especialidad != D)
            {
                Debug.Log("Solo se puede ingresar T, G, H, D o M");
            }
            if (especialidad != M)
            {
                Debug.Log("Solo se puede ingresar T, G, H, D o M");
            }


        }
        else
        {
            Debug.Log("Muchas gracias, ", nombre);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
