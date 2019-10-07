using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public bool gameHasEnded = false;
   public float gameDelay = 2f;
   public GameObject completeLevelUi;

   public void CompleteLevel()
   {
      completeLevelUi.SetActive(true);
   }
   public void EndGame()
   {
      if (gameHasEnded == false)
      {
         gameHasEnded = true;
         Debug.Log("Game Over!");
         Invoke("Restart", gameDelay);
      }
   }

   void Restart()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
