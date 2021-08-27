using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    bool isShotting = false;
    Rigidbody2D rb; 
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            StartShot();
        } else if(Input.GetMouseButtonUp(0)){
            StopShot();    
        }

        if(isShotting)
        {
            UpdateShot();
        }
    }

    void UpdateShot()
    {
        
    }

    void StartShot()
    {
        isShotting = true;
    }

    void StopShot()
    {
        isShotting = false;
    }
}
