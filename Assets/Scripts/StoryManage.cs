using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManage : MonoBehaviour
{
    public GameObject story11, story12, story13;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        open_story11();
    }

    public void open_story11()
    {
        story11.SetActive(true);
        hide_story12();
        hide_story13();
    }
    public void hide_story11()
    {
        story11.SetActive(false);
        
    }
    public void open_story12()
    {
        story12.SetActive(true);
        hide_story11();
        hide_story13();
    }
    public void hide_story12()
    {
        story12.SetActive(false);

    }
    public void open_story13()
    {
        story13.SetActive(true);
        hide_story11();
        hide_story12();
    }
    public void hide_story13()
    {
        story13.SetActive(false);
    }
    public void startGame()
    {
        hide_story11();
        hide_story12();
        hide_story13();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
