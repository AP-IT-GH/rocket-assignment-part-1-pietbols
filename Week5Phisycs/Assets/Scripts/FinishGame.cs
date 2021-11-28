using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public Text scoreBoard;
    public Text finalScore;
    public GameObject endScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endScreen.SetActive(true);
            finalScore.text = "You scored: " + scoreBoard.text + " points";

            if (scoreBoard.text == "1")  // you scored 1 point
            {
                finalScore.text = finalScore.text.Remove(finalScore.text.Length - 1);
            }
        }
    }
}
