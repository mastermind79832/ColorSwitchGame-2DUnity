using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float JumpForce;

    private Rigidbody2D rb;

    private string currentColor;
    private SpriteRenderer sr;

    public Color[] gameColors;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * JumpForce;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(other.gameObject);
        }

        if(other.tag == currentColor)
        {
            Debug.Log( other.tag);
        }


    }


    private void SetRandomColor()
    {

        int index = Random.Range(0, 4);
            
            
            switch(index)
            {
                case 0 :
                    currentColor = "cyan";
                    sr.color = gameColors[0];
                    break;
                case 1 :
                    currentColor = "yellow";
                    sr.color = gameColors[1];
                    break;
                case 2 :
                    currentColor = "violet";
                    sr.color = gameColors[2];
                    break;
                case 3 :
                    currentColor = "pink";
                    sr.color = gameColors[3];
                    break;
            }   
    

    }

}
