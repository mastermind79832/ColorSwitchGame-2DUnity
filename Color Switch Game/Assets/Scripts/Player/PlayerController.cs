
using UnityEngine;

public class PlayerController 
{
   private PlayerModel playerModel;
   private PlayerView playerView;
   private Rigidbody2D rigidbody2D;


    //constructor
    public PlayerController(PlayerModel model, PlayerView view) 
    {
        playerView = GameObject.Instantiate<PlayerView>(view);
        playerModel = model;

        playerModel.SetPlayerController(this);
        playerView.SetPlayerController(this);

        GameObject.Find("Main Camera").GetComponent<FollowPlayer>().player = playerView.gameObject.transform;

        rigidbody2D = playerView.gameObject.GetComponent<Rigidbody2D>();

    }


   public void PlayerMove()
   {
        // playerView.gameObject.transform.position += Vector3.up * Time.deltaTime * playerModel.GetMoveSpeed();
        rigidbody2D.velocity = Vector2.up * playerModel.GetMoveSpeed();
   }

   public void ChangeColor(Color color)
   {
        playerView.gameObject.GetComponent<SpriteRenderer>().color = color;
   }

}
