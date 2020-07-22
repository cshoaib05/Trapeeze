using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Pendullum : MonoBehaviour
{
    Rigidbody rb;
    public Camera camera;
    public GameObject ScoreController;

    float offset;
    Vector3 tempos;

    private void Start()
    {
        camera = Camera.main;
        offset = transform.position.z - camera.transform.position.z;
        rb = transform.parent.gameObject.GetComponent<Rigidbody>();
        ScoreController.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(new Vector3(transform.forward.x * 15f, 0, 0));
        }

        if (Input.GetMouseButtonUp(0))
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0,0,transform.forward.z *20f));
            ScoreController.SetActive(false);
        }


        tempos = transform.position;
        tempos.z = transform.position.z - offset;
        camera.transform.position = tempos;
    }
}
