using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > TimeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(1, Random.Range(-1f, 3.3f), 0); // -1 3.3
            timer = 0;
            Destroy(newpipe, 5.0f); 
        }
    }
}
