using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace DanielCairney
{

    public class LevelLoader : MonoBehaviour
    {
        private void Update()
       {
          if(Input.GetKeyDown(KeyCode.X))
          {
              LoadLevel("WeeKTwoActivities");
          }
       }
       
       
        /// <summary>
        ///this will load a different scene
        ///</summary>
        private void LoadLevel(string sceneToLoad)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}