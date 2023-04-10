using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createobj : MonoBehaviour
{
    [SerializeField] public GameObject[] objects;
    private float random;
    private Vector2 coord;
    private float sp1 = 2f;
    private float sp2 = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > sp2)
        {

            sp2 = Time.time + sp1;
            random = Random.Range(-7.83f, 7.24f);
            int rand2 = Random.Range(0, 3);
            GameObject obj = objects[rand2];
            coord = new Vector2(random, transform.position.y);
            Instantiate(obj, coord, Quaternion.identity);         
        }

       

    }

   
    }



