using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour {
  public Transform target;
  public GameObject player_1, player_2;
  public Vector3 offset;
  public float smoothSpeed = 0.125f;
  // Use this for initialization
  void Start()
  {
    player_1.GetComponent<GameObject>();
  }

  // Update is called once per frame
  void LateUpdate()
  {
    Vector3 desirePosition = new Vector3((player_1.transform.position.x + player_2.transform.position.x) / 2, (player_1.transform.position.y + player_2.transform.position.y) / 2);
    desirePosition = desirePosition + offset;
    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
    transform.position = smoothedPosition;
  }
}
