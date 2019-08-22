using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    

    public void MainMenu(string infoScene)
    {
        SceneManager.LoadScene(infoScene);
		Data.prevScene = infoScene;

        //Data.infoScene = infoScene;
        //sound.Play();
        //		textText.text = Data.infoScene;
    }
    public void NextLevel()
    {
        if(Data.prevScene == "Level1")
        {
            SceneManager.LoadScene("Level2");
            Data.prevScene = "Level2";
        } else if (Data.prevScene == "Level2")
        {
            SceneManager.LoadScene("Home");
            Data.prevScene = "Home";
        }
    }


    // Update is called once per frame
    /*void Update()
    {
        
    }
    */
}
