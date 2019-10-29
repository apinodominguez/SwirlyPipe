using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Player player;
    public Text scoreLabel;

    public void StartGame(int mode)
    {
        player.StartGame(mode);
        gameObject.SetActive(false);
        Cursor.visible = false;
    }

    public void EndGame(float distanceTraveled)
    {
        scoreLabel.text = ((int)(distanceTraveled * 10f)).ToString();
        gameObject.SetActive(true);
        Cursor.visible = true;
    }

    private void Awake()
    {
        Application.targetFrameRate = 1000;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
