using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 10;
    public float y = 5;
    public float result = 0;
    private void Start()
    {
        Debug.Log(result = x + y);
        Debug.Log(result = x - y);
        Debug.Log(result = x * y);
        Debug.Log(result = x / y);
        Debug.Log(result = x % y);
    }
}
