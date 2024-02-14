using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursiveStairs : MonoBehaviour
{
    [SerializeField] Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        Debug.Log("Fibonacci Solution: " + Fibonacci(5));
        
        if (transform.localScale.x > 0.1)
        {
            Debug.Log("New Cube Created");
            GameObject newCube = Instantiate(gameObject) as GameObject;

            newCube.transform.localScale = transform.localScale / 2;

            newCube.transform.position = new Vector3(transform.position.x,
                                                 transform.position.y + renderer.bounds.size.y,
                                                 transform.position.z);
        }
    }

    //int Fibonacci(int x)
    //{
    //    if (x > 1)
    //    {
    //        return Fibonacci(x - 1) + Fibonacci(x - 2);
    //    } else
    //    {
    //        return x;
    //    }
            
    //}

     int Fibonacci(int x)
    {
        if (x > 1)
        {
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
        else
        {
            return x;
        }

    }
}
