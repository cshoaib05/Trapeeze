using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    public GameObject Player;
    float offset;
    Vector3 tempos;
    private void Start()
    {
        offset = Player.transform.position.z - transform.position.z;
    }
    private void Update()
    {
        tempos = Player.transform.position;
        tempos.z = Player.transform.position.z - offset;
        transform.position = tempos;
    }
}
