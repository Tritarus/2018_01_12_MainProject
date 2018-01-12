using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollBall : MonoBehaviour {

    [SerializeField] [Range(0, 360)] private float x_axe;
    [SerializeField] [Range(0, 360)] private float y_axe;
    [SerializeField] [Range(0, 360)] private float z_axe;


    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        transform.Rotate(new Vector3(x_axe, y_axe, z_axe));
    }
}
