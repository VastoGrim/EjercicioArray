using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ejemplosArray : MonoBehaviour
{
    public GameObject[] ballsarray;
    public List<GameObject> ballscatch;
    private bool catchball = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           GameObject a =  Instantiate(ballsarray[Random.Range(0, ballsarray.Length)], new Vector3(Random.Range(-5, 5),Random.Range(-10,10)), Quaternion.identity);
            ballscatch.Add(a);
        }
    }
}
