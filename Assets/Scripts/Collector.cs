using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject maincube;
    bool isFirst = true;
    public float height;
    public List <GameObject> collected=new List<GameObject>();
    void Start()
    {
        maincube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pick")
        {
            
            if (isFirst == true)
            {
                collected.Add(other.gameObject);
                other.transform.parent = maincube.transform;
                maincube.transform.GetChild(1).transform.localPosition = new Vector3(0, 1.5f, 0);
                other.transform.localPosition = new Vector3(0, 1, 0);
                
                isFirst = false;
                height++;
            }
            else {
                height++;
                collected.Add(other.gameObject); 
                other.transform.parent = maincube.transform;
                maincube.transform.GetChild(1).transform.localPosition = new Vector3(0, height+.5f, 0);
                other.transform.localPosition = new Vector3(0, height, 0);
                
       

            }


        }
        if (other.gameObject.tag == "Obstacle" || other.gameObject.tag=="Multiplier")
        {
            if (this.transform.parent.childCount <= 2)
            {

                print("Collision");

                SceneManager.LoadScene("SampleScene");

            }
        }
        
    }
}
