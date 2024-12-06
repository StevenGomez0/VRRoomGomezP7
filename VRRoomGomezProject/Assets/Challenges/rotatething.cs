using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatething : MonoBehaviour
{
    public Slider Slider;
    public Transform pedestal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pedestal.transform.rotation = Quaternion.Euler(0, Slider.value * 36, 0);
    }
}
