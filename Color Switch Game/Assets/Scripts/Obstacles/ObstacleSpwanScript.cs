using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwanScript : MonoBehaviour
{

    public int obstacleSpwanCount;
    public float obstacleDistance;

    [System.Serializable]
    public class obstacles
    {
        public string obsName;
        public ObstacleView obstacle;

        
        // no of objects in the obstacle that are rotating with rotation script 
        // and instantiated at the same time
        // 0 = above mentioned obstacle is rotating
        //example :circle
        // 2 = 2 objects rotating and instantiated at same time
        //example : cross
        public float rotatingObjectCount;

        public float speed;
        
        //is the object rotating or moving vertically
        public bool isRotate = true;
    }

    public GameObject finishLine;

    public Color[] colors;

    public GameObject colorchanger;

    public List<obstacles> obstacleList;


    private int prevColorIndex;

    // Start is called before the first frame update
    void Start()
    {
        prevColorIndex = -1;
        
        CreateObstacle(obstacleSpwanCount);
            
 
    }

    // Update is called once per frame
    void Update()
    {

        // if(Input.GetKeyDown(KeyCode.A))
        // {
        //     CreateObstacle(0);
        // }
        
    }

    public void CreateObstacle(int count)
    {


        int colorIndex ;

        for(int i=0; i< count ; i++)
        {
            colorIndex = Random.Range(0,colors.Length);
            if(prevColorIndex == colorIndex)
                continue;

            SpwanChanger(colorIndex);
  
            SpwnaObstacle(colorIndex);

            prevColorIndex = colorIndex;
            transform.position += new Vector3(0f,obstacleDistance);
        }

        Instantiate<GameObject>(finishLine,transform.position,Quaternion.identity);

    }


    private void SpwanChanger(int index)
    {
        Vector3 pos =new Vector3(0f,transform.position.y - 7);
        GameObject changer = Instantiate<GameObject>(colorchanger,pos,Quaternion.identity);

        changer.GetComponent<SpriteRenderer>().color = colors[index];


    }


    private void SpwnaObstacle(int colorIndex)
    {

        int index = Random.Range(0,obstacleList.Count);


        ObstacleModel obstacleModel = new ObstacleModel(obstacleList[index].speed, obstacleList[index].rotatingObjectCount,colors[colorIndex]);// speed and count

        ObstacleController obstacleController = new ObstacleController(obstacleModel,obstacleList[index].obstacle, transform.position, colors);// model and view

    }
}
