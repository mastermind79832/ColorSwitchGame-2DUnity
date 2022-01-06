using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{

    private PlayerController playerController;

    private GameOverScript gameOverScript;
    private LevelWonScript levelWonScript;

    private bool isKeyPressed;
    // private float time = 0.8f;

    private void Awake()
    {
        gameOverScript = GameObject.Find("GameOverPanel").GetComponent<GameOverScript>();
        levelWonScript = GameObject.Find("LevelWonPanel").GetComponent<LevelWonScript>();
        gameOverScript.gameObject.SetActive(false);
        levelWonScript.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        isKeyPressed = false;

    }

   

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)||Input.GetButtonDown("Jump"))
        {
            isKeyPressed = true;

            playerController.PlayerMove();
        }

        if(!isKeyPressed && transform.position.y < -3.55)
        {
            playerController.PlayerMove();
        }


        // if(!isKeyPressed)
        //     AutoJump();

    }

    

    
    
    
    // private void AutoJump()
    // {
    //     if(time >= 1.05f)
    //     {    
    //         playerController.PlayerMove();
    //         time = 0;
    //         return;
    //     }
    //     time += Time.deltaTime; 
    // }

    public void SetPlayerController(PlayerController controller)
    {
        playerController = controller;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        //ignore parent obstacles and increaseScore
        if(other.tag == "Obstacle")
        {    
            //increase score
            return;
        }

        //if player fell down the screen
        if(other.name == "GameEnd")
        {
            Debug.Log("Player dead");
            gameOverScript.GameOver();
            return;
        }

        //if player reached the finish line
        if(other.tag == "Finish")
        {
            levelWonScript.LevelWon();
            return;
        }

        
        Color otherColor = other.gameObject.GetComponent<SpriteRenderer>().color;

        //if player collide with color change
        if(other.tag == "ColorChanger")
        {
            playerController.ChangeColor(otherColor);
    
            Destroy(other.gameObject);
        }
        
        //if player collide with wrong color
        if(otherColor != gameObject.GetComponent<SpriteRenderer>().color)
        {
            Debug.Log("GameOver");
            gameOverScript.GameOver();
        }
            
        
    }

   
        
}
