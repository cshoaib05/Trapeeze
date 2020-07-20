using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversePlayer : MonoBehaviour
{
    public GameObject doublePlayer;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("flyer"))
        {
            doublePlayer.SetActive(true);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
