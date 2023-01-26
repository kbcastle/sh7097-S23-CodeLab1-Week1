using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public float destroyTime;
    public GameObject destroyObject;
    
    void DestroyObjectDelayed()
    {
        Destroy(destroyObject, destroyTime);
    }
    
}
