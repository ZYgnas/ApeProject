using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    int scene = 1;
    public void EasyScene()
    {
        scene = 1;
    }
    public void NormalScene()
    {
        scene = 2;
    }
    public void HardScene()
    {
        scene = 3;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
