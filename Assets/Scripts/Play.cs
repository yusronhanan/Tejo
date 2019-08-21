using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void MainMenu(string infoScene)
    {
        SceneManager.LoadScene(infoScene);
        //Data.infoScene = infoScene;
        //sound.Play();
        //		textText.text = Data.infoScene;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }
    */
}
