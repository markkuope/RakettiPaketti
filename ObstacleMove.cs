using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    
    [SerializeField] float moveTime = 2;
    [SerializeField] float speed = 4;

    bool obstacleMove = false;

    void Start()
    {
        obstacleMove = true;
    }

    void Update()
    {
        MoveObstacle();
    }

    void MoveObstacle()
    {
        if (obstacleMove)
        {
            transform.position += transform.right * speed * Time.deltaTime;
            Invoke("StopMoveObstacle", moveTime);
        }
        else
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }

    void StopMoveObstacle()
    {
        obstacleMove=false;
        Invoke("StartMoveObstacle", moveTime);
    }

    void StartMoveObstacle()
    {
        obstacleMove = true;
    }

}
