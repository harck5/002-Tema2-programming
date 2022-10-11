using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
//Variable wheels num de ruedas
[SerializeField] private int wheels = 4;
    private void Start()
    {
        Debug.Log("El veiculo tiene" {0}, wheels);
    }
}
