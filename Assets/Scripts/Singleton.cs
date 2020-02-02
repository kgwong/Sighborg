using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Dictionary<string, Singleton> singletons = new Dictionary<string, Singleton>();
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (singletons.ContainsKey(gameObject.name))
        {
            DestroyObject(gameObject);
        }
        else
        {
            singletons.Add(gameObject.name, this);
        }
    }
}
