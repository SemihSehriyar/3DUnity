using System;
using System.Collections;
using System.Collections.Generic;
using UnityProject.Inputs;
using UnityEngine;


namespace UnityProject.Controllers
{
	public class PlayerController : MonoBehaviour
	{
		[SerializeField] float force;
		private Rigidbody _rigidbody;
		private DefaultInput _input;

		private bool _isForcedUp;
			

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody>();
			_input = new DefaultInput();
		}

		private void Update()
		{
			if (_input.IsForcedUp) 
			{
				_isForcedUp = true;
			}
			else 
			{
				_isForcedUp = false;
			}
		}

		private void FixedUpdate()
		{
			if (_isForcedUp) 
			{
				_rigidbody.AddForce(Vector3.up * Time.deltaTime * force);
			}
		}
	}
}