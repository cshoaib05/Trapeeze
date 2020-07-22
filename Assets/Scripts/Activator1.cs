﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator1 : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flyer"))
        {
            other.gameObject.SetActive(false);
            player.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
