using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    // Rigidbody2D rb;
    // void Start(){
    //     rb = GetComponent<Rigidbody2D>();
    // }

    public void Shoot() {

        RaycastHit2D hit = Physics2D.Raycast(arCamera.transform.position, arCamera.transform.forward);

        if (hit.collider != null)
        {
             Debug.Log("Hit point" + hit.transform.name);

             if (hit.transform.name == "Banana(Clone)") {

                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
           
        }
    }
}
