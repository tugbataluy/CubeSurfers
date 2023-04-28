using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collected : MonoBehaviour
{
    public Collector collector;
    public int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle") {
            
           // print(this.transform.localPosition);
            
            collector.collected.Remove(this.gameObject);
            for (int i = 0; i < collector.collected.Count; i++)
            {
                if (collector.collected[i].transform.localPosition.y > this.gameObject.transform.localPosition.y)
                {
                    collector.collected[i].transform.localPosition = new Vector3(0, collector.collected[i].transform.localPosition.y - 1, 0);


                }
               
            }
            collector.transform.parent.GetChild(1).localPosition = new Vector3(0, collector.transform.parent.GetChild(1).localPosition.y - 1, 0);
            this.transform.parent = null;
            this.GetComponent<Collider>().enabled = false;
            other.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject,.5f);
            collector.height--;
            
        }
        
            

        




    }
}
