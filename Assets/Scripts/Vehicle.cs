using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
//Variable wheels num de ruedas
        [SerializeField] private int wheels = 4 ;
        [SerializeField] private string name = "car";
        [SerializeField] private bool isOn;
        [SerializeField] private float gasoline;
        


    public string sound = "brum brum brum";
    private void Start()
    {
        /*Debug.Log(message: string.Format("Tu vehiculo es {0} y tiene {1} ruedas" , name , wheels)) ;
        if (isOn == true)
        {
            Debug.Log($"El {name} esta encendido");
        }
        else
        {
            Debug.Log($"La {name} esta apagado");
        }
        if (isOn == false)
        {
            Debug.Log($"{name} esta apagado");

        }
        else if (sound != "")
        {
            Debug.Log($"{sound}");
        }
        else
        {
            Debug.Log($"{name} en marcha");
        }
        if (isOn == true)
        {
            if (gasoline < 10) {
                Debug.Log(message: $"{name} le queda {gasoline} gasolina");
            }
            else
            {
            Debug.Log(message: $"{name} esta lleno");
            } 
        }
        else 
        {
            Debug.Log(message: $"{name} esta apagado");
        }*/
        if (isOn == true && gasoline < 10)
        {
            Debug.Log(message: $"{name} esta en marcha y queda {gasoline} litros de gasolinas");
        }

        else if (gasoline == 10)
            {
                Debug.Log(message: $"{name} esta en marcha y esta lleno");
            }
       
        else
        {
            Debug.Log(message: $"{name} esta apagado y tiene {gasoline} gasolina");
        }
    }
    
}
