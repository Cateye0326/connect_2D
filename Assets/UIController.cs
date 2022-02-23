using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    private GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText = GameObject.Find("Gameover");
        this.gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        this.gameOverText.SetActive(true);
    }
}
