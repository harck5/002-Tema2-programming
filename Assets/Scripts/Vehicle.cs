using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
//Variable wheels num de ruedas
[SerializeField] private int wheels = 4 ;
[SerializeField] private string name = "car";
    private void Start()
    {
        Debug.Log(message: string.Format("Tu vehiculo es {0} y tiene {1} ruedas" , name , wheels)) ;
    }
}
