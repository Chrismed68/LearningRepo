using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Object brick;

    // Start is called before the first frame update
    void Start()
    {
        //front wall
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                Instantiate(brick, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                Instantiate(brick, new Vector3(j, i, 0), Quaternion.identity);
            }
        }
        for (int j = 7; j < 15; j++)
        {
            Instantiate(brick, new Vector3(8, j, 8), Quaternion.identity);
            Instantiate(brick, new Vector3(9, j, 9), Quaternion.identity);
            Instantiate(brick, new Vector3(8, j, 9), Quaternion.identity);
            Instantiate(brick, new Vector3(9, j, 8), Quaternion.identity);
        }
        for (int j = 0; j < 10; j++)
        {
            Instantiate(brick, new Vector3(6, j, 0), Quaternion.identity);
        }
        for (int j = 0; j < 10; j++)
        {
            Instantiate(brick, new Vector3(j, 6, 0), Quaternion.identity);
        }
        //front wall
        for (int j = 0; j < 10; j++)
        {
            for (int i = 10; i < 10; i--)
            {
                Instantiate(brick, new Vector3(j, i, 0), Quaternion.identity);
            }
        }
        //leftWall
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(brick, new Vector3(0, j, i), Quaternion.identity);
            }
        }
        //back
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(brick, new Vector3(i, j, 10), Quaternion.identity);
            }
        }
        //otherWall
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(brick, new Vector3(9, j, i), Quaternion.identity);
            }
        }
        //floor
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(brick, new Vector3(j, 0, i), Quaternion.identity);
            }
        }
        //roof
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {

                Instantiate(brick, new Vector3(j, 9, i), Quaternion.identity);

            }
            }
        }




    // Update is called once per frame
    void Update()
    {
        
    }
}
