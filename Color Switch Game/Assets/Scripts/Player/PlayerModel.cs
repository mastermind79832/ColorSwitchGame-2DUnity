
using UnityEngine;

public class PlayerModel 
{

    private PlayerController playerController;

    private float moveSpeed;


    //model constructor
    public PlayerModel(float speed)
    {
        moveSpeed = speed;
    }

    public void SetPlayerController(PlayerController controller)
    {
        playerController = controller;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

}
