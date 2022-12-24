using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private int Skor;
    public int totalSkor;

    EasyFileSave myFile;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int skor
    {
        get
        {
            return Skor;
        }
        set
        {
            Skor = value;
            GameObject.Find("Skor").GetComponent<Text>().text = Skor.ToString();
        }
    }

    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();
    }

    public void SaveData()
    {
        totalSkor += Skor;

        myFile.Add("totalSkor", totalSkor);
        myFile.Save();
    }

    public void LoadData()
    {
        if (myFile.Load())
        {
            totalSkor = myFile.GetInt("totalSkor");
        }
    }
}
