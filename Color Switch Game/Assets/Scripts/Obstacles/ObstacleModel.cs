
using UnityEngine;

public class ObstacleModel 
{

    private ObstacleController obstacleController;

    private float rotationSpeed;
    private float childCount;
     
    private Color playerColor;

    public ObstacleModel(float Speed, float count, Color color)
    {
        rotationSpeed = Speed;
        childCount = count;
        playerColor = color;
    }

    public void SetObstacleController(ObstacleController controller)
    {
        obstacleController = controller;
    }

    public float Getspeed()
    {
        return rotationSpeed;
    }

    public float GetCount()
    {
        return childCount;
    }

    public Color GetPlayerColor()
    {
        return playerColor;
    }
    
}
