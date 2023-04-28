using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube: MonoBehaviour
{
    [SerializeField] float horizontalspeed;
    [SerializeField] float verticalspeed;
    public bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= -139.8)
        {

            float horizontalAxis = Input.GetAxis("Horizontal") * horizontalspeed * Time.deltaTime;
            this.transform.Translate(horizontalAxis, 0, verticalspeed * Time.deltaTime);

        }
        else
            isMoving = false;
        
    }
}
