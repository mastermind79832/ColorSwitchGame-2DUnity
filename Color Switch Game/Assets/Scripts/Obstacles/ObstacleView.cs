using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleView : MonoBehaviour
{

    private ObstacleController obstacleController;

    // Start is called before the first frame update
    void Start()
    {
        obstacleController.SetObstacleColors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetObstacleController(ObstacleController controller)
    {
        obstacleController = controller;
    }

}
