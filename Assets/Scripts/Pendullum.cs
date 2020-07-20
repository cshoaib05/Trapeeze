using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendullum : MonoBehaviour
{
    Rigidbody rb;
    
    public static int indexinplay;
    public GameObject flyer;
    private void Start()
    {
         rb =transform.parent.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
            if (Input.GetMouseButton(0))
            {
                rb.AddForce(new Vector3(transform.forward.x * 10f, 0, 0));

            }

            if (Input.GetMouseButtonUp(0))
            {
                flyer.transform.position = transform.position;
                flyer.SetActive(true);
                flyer.GetComponent<Rigidbody>().AddForce(transform.forward * 600f);
                gameObject.SetActive(false);
            }
        
    }
}
