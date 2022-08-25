using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    [SerializeField] private float _rotatingSpeed;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = new Vector3(2f, 1f, 3f);
        
        Material material = Renderer.material;
       
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime*_rotatingSpeed, 2.0f*Time.deltaTime, 0.0f);

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            float x = Random.Range(0, 10f);
            float y = Random.Range(0, 10f);
            float z = Random.Range(0, 10f);
            transform.localScale = new Vector3(x,y,z);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rotatingSpeed = Random.Range(5f, 100f);
        }

       

    }
}
