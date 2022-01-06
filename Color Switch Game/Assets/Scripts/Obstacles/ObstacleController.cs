
using UnityEngine;

public class ObstacleController
{
    private ObstacleModel obstacleModel;
    private ObstacleView obstacleView;

    private Color[] colors;


    public ObstacleController(ObstacleModel model, ObstacleView view, Vector3 pos, Color[] colours)
    {
        obstacleModel = model;
        obstacleView = GameObject.Instantiate<ObstacleView>(view,pos,Quaternion.identity);
        colors = colours;
    

        obstacleModel.SetObstacleController(this);
        obstacleView.SetObstacleController(this);

        if(obstacleModel.GetCount()>0)
        {
            for(int i =0; i< obstacleModel.GetCount(); i++)
            {
                float speed = obstacleModel.Getspeed();
                if(i % 2 == 0)
                    speed *= -1;

                obstacleView.gameObject.transform.GetChild(i).GetComponent<rotator>().SetSpeed(speed);
            }
        }
        else
        {
            obstacleView.gameObject.GetComponent<rotator>().SetSpeed(obstacleModel.Getspeed());
        }


    }

    public void SetObstacleColors()
    {

        Color playerColor = obstacleModel.GetPlayerColor();

        if(obstacleModel.GetCount()>0)
        {
            for(int i =0; i< obstacleModel.GetCount(); i++)
            {
                ChangeColor(playerColor,obstacleView.gameObject.transform.GetChild(i));

            }
        }
        else
        {
            ChangeColor(playerColor,obstacleView.gameObject.transform);
        }

    }

    private void ChangeColor(Color playerColor, Transform obstacles)
    {
        
        int count = obstacles.transform.childCount;

        if(count == 1)
        {   
            obstacles.GetChild(0).GetComponent<SpriteRenderer>().color = playerColor;//set first color to be playercolor
            return;
        }

        obstacles.GetChild(0).GetComponent<SpriteRenderer>().color = playerColor;//set first color to be playercolor

        for(int i = 1; i < count; i++)
        {
            int index = Random.Range(0,colors.Length);
            obstacles.GetChild(i).GetComponent<SpriteRenderer>().color = colors[index];//set their color as random
        }
        
        

    } 
    
}
