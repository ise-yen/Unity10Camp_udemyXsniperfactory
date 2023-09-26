using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Freeze : MonoBehaviour
{
	public Transform cam;

	private void Start()
	{
		GameObject camObj = GameObject.Find("Camera");
		cam = camObj.transform;
	}
	private void LateUpdate()
	{
		transform.LookAt(new Vector3(0, 0, 90));
	}
}
