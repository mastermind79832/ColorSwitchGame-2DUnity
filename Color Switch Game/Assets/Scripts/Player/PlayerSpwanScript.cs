using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwanScript : MonoBehaviour
{

    public PlayerView[] player;

    public float jumpSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpwanPlayer();

    }

    private void SpwanPlayer()
    {
        int index =0;


        PlayerModel playerModel = new PlayerModel(jumpSpeed);//movement speed

        PlayerController playerController = new PlayerController(playerModel,player[index]);// model and view
    }
}
