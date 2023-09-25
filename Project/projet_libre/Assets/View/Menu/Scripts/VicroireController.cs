using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VicroireController : MonoBehaviour
{
      public void restarte(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
     public void mainMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
