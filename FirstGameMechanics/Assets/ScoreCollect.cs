using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollect : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    private void OnTriggerEnter(Collider other)
    {
        theScore += 1;
        scoreText.GetComponent<Text>().text = "NOTES: " + theScore;
        Destroy(gameObject);
    }
}