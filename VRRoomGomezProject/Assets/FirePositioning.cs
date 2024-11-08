using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePositioning : MonoBehaviour
{
    public Transform postion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = postion.position;
    }
}
