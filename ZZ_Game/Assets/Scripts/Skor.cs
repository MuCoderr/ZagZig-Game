using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public static int skor;
    public Text skorText;

    // Start is called before the first frame update
    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = skor.ToString();
    }
}
