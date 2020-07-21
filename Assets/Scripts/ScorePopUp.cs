using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePopUp : MonoBehaviour
{
    public TextMeshProUGUI score;
    private void Start()
    {
        StartCoroutine(hideScore());
    }
    void Update()
    {
        Vector3 scorepos = Camera.main.WorldToScreenPoint(this.transform.position);
        score.transform.position = scorepos;
    }
    IEnumerator hideScore()
    {
        score.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        score.gameObject.SetActive(false);
    }
}
