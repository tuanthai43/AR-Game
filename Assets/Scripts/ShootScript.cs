using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    public Text scoreText;
    private int fruits = 0;

    

    public void Shoot() {

        RaycastHit2D hit = Physics2D.Raycast(arCamera.transform.position, arCamera.transform.forward);

        if (hit.collider != null)
        {
             Debug.Log("Hit point" + hit.transform.name);

             if (hit.transform.name == "Banana(Clone)" ||hit.transform.name == "Olive(Clone)" ||hit.transform.name == "Watermelon(Clone)" ) {

                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                fruits = fruits + 10;
                scoreText.text = "Score: " + fruits;
            }
           
        }
    }
}
