using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour {

  float z = -10;
  public float zoom=30;
  public float smooth=10;
  public float norm = 60;
  public float alejarse = 100;
  public float position;
  public GameObject player1, player2;
	void Start () {
    GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, z);
   
  }
	
	// Update is called once per frame
	void Update () {
  position=player1.GetComponent<Transform>().position.x- player2.GetComponent<Transform>().position.x;

    Debug.Log(position);
    if (Mathf.Abs(position)<=3.8)
      //GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y,z-=0.5f );
      GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
    else if(Mathf.Abs(position)<=10)
      GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, norm, Time.deltaTime * smooth);
    else
      GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, alejarse, Time.deltaTime * smooth);
  }

 
}
