using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject inGameScreen, pauseScreen, optionsScreen;
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }

    public void RePlayButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OptionsButton()
    {
        pauseScreen.SetActive(false);
        optionsScreen.SetActive(true);
    }

    public void OptionsExitButton()
    {
        optionsScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }

    public void SetMusic(bool isMusic)
    {
        music.mute = !isMusic;
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(1);
        DataManager.Instance.SaveData();
    }
}
