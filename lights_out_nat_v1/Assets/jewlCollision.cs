using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jewlCollision : MonoBehaviour
{
    float yval;
    private int jewlValue = 1;
    bool floatup;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        //yval = transform.position.y;
        floatup = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            scoreScript.scoreValue += 10;
        }
    }
    /*
     private bool floatUp()
    {
        yval += 0.4f * Time.deltaTime; 
        yield return new WaitForSeconds(1); 
        floatup = false;

    }

    private bool floatDown()
    {
        yval -= 0.3f * Time.deltaTime;
        yield return new WaitForSeconds(1);
        floatup = true;
    }
    */
}
