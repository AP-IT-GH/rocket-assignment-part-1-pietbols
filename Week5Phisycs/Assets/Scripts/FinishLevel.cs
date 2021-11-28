using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public string mLevelToLoad;
   
    private void OnTriggerEnter(Collider collision)
    {
        if (this.tag == "Finish" && collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(mLevelToLoad);
        }
    }
}
