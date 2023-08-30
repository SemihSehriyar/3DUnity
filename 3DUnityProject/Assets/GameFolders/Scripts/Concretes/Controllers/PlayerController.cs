using System;
using System.Collections;
using System.Collections.Generic;
using UnityProject.Inputs;
using UnityProject.Movements;
using UnityEngine;


namespace UnityProject.Controllers
{
	public class PlayerController : MonoBehaviour
	{
		private Mover _mover;
		private DefaultInput _input;

		private bool _isForcedUp;
			

		private void Awake()
		{	
			_input = new DefaultInput();
			_mover = new Mover(GetComponent<Rigidbody>());
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
				_mover.FixedTick();
			}
		}
	}
}