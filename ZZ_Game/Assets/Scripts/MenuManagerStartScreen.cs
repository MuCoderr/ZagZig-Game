using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerStartScreen : MonoBehaviour
{
    public GameObject startMenu, optionsMenu, skorBoard;
    public string Url;
    public AudioSource music;
    public GameObject dataBoard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void OptionsMenu()
    {
        startMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void OptionsExitButton()
    {
        optionsMenu.SetActive(false);
        startMenu.SetActive(true);
    }

    public void OpenUrl()
    {
        Application.OpenURL(Url);
    }

    public void SetMusic(bool isMusic)
    {
        music.mute = !isMusic;
    }

    public void SkorBoardButton()
    {
        DataManager.Instance.LoadData();

        startMenu.SetActive(false);
        skorBoard.SetActive(true);
        dataBoard.transform.GetChild(2).GetComponent<Text>().text = DataManager.Instance.totalSkor.ToString();
    }

    public void SkorBoardExitButton()
    {
        skorBoard.SetActive(false);
        startMenu.SetActive(true);
    }


}
