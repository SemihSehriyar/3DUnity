using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody _rigidbody;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		//input
	}

	private void FixedUpdate()
	{
		// fizik islemleri		
	}
}