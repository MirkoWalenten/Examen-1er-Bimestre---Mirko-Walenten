using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public string codigo;
    public int dias;

    // Start is called before the first frame update
    void Start()
    {
        if (dias < 3)
        {
            Debug.Log("Error");
        }
        else if (codigo != "g" && codigo != "pp" && codigo != "pg")
        {
            Debug.Log("Error");
        }
        else if (codigo == "g")
        {
            int g = 300;
            int peso = g * dias;
            Debug.Log("Para ese periodo se necesitan " + peso + " gramos de alimento");
            int alimento = peso / 100;
            int costo = alimento * 80;
            Debug.Log("El costo por esta cantidad de gramos de alimento es de " + costo + " pesos");
        }
        else if (codigo == "pp")
        {
            int pp = 400;
            int peso = pp * dias;
            Debug.Log("Para ese periodo se necesitan " + peso + " gramos de alimento");
            int alimento = peso / 100;
            int costo = alimento * 80;
            Debug.Log("El costo por esta catidad de gramos de alimento es de " + costo + " pesos");
        }
        else if (codigo == "pg")
        {
            int pg = 700;
            int peso = pg * dias;
            Debug.Log("Para ese periodo se necesitan " + peso + " gramos de alimento");
            int alimento = peso / 100;
            int costo = alimento * 80;
            Debug.Log("El costo por esta catidad de gramos de alimento es de " + costo + " pesos");
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}