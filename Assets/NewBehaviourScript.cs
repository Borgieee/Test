using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        float RandomX = Random.Range(-10f, 10f);
        float RandomY = Random.Range(-10f, 10f);
        Debug.Log("Test");
        transform.position = new Vector3(RandomX,RandomY,0);
        


    }
}

