using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelWon()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
