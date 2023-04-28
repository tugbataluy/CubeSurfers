using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreMultiplier : MonoBehaviour
{
    // Start is called before the first frame update
    int multiply=1;
    public bool isFinished = false;
    public MoveCube move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!move.isMoving) {
            for (int i = this.transform.childCount - 1; i >= 2; i--) { 
                Destroy(this.transform.GetChild(i).gameObject);
            
            }
            this.transform.GetChild(1).localPosition=new Vector3(0,.5f,0);
        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Multiplier") {
            if (!isFinished)
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z);
                print("Collided with mult.");
                print(this.transform.childCount);
                multiply = this.transform.childCount - 1;
                print(multiply);
                isFinished = true;
            }
        }    
    }
    
}
