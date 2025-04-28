using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float cantidadCarga;
    public float distanciaKM;
    float kmPorHora = 25f;
    float horasTotales;
    float precioporhoraU = 3000;
    float precioporhoraP = 4500;
    float precioporhoraC = 7000;
    float precioTotal;
    string vehiculo;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadCarga < 100)
        {
            Debug.Log("Error, la cantidad mínima de carga es de 100 kg");
            return;
        }

        else if (cantidadCarga > 10000)
        {
            Debug.Log("Error, la cantidad de carga no puede ser superior a 10000");
            return;
        }

        else if (cantidadCarga < 2000 & cantidadCarga > 100)
        {
            vehiculo = "utilitario";
            horasTotales = distanciaKM / kmPorHora;
            precioTotal = horasTotales * precioporhoraU;
            Debug.Log($"El vehículo necesario es el {vehiculo} y el precio total es de {precioTotal}");
        }

        else if (cantidadCarga < 5000 & cantidadCarga > 2000)
        {
            vehiculo = "pickup";
            horasTotales = distanciaKM / kmPorHora;
            precioTotal = horasTotales * precioporhoraP;
            Debug.Log($"El vehículo necesario es el {vehiculo} y el precio total es de {precioTotal}");
        }

        else if (cantidadCarga < 10000 & cantidadCarga > 5000)
        {
            vehiculo = "camión";
            horasTotales = distanciaKM / kmPorHora;
            precioTotal = horasTotales * precioporhoraC;
            Debug.Log($"El vehículo necesario es el {vehiculo} y el precio total es de {precioTotal}");
        }


        if (distanciaKM < 1)
        {
            Debug.Log("Error, la distancia no puede ser menor a 1");
            return;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
