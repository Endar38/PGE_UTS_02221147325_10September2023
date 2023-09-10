using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject LevelPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        LevelPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        LevelPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }
    public void Quit_Clicked()
    {
        Application.Quit();
    }

    public void Level1Clicked()
    {
        Application.LoadLevel("GameplayLevel1");
    }
    public void Level2Clicked()
    {
        Application.LoadLevel("GameplayLevel2");
    }
    public void KembaliClicked()
    {
        Application.LoadLevel("MainMenu");
    }
}
