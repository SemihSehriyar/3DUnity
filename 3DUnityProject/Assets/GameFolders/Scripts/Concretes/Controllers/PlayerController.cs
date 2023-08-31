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
		[SerializeField] private float _turnSpeed = 10f;
		[SerializeField] private float _force = 55f;

		private Mover _mover;
		private Rotator _rotator;
		private DefaultInput _input;

		private bool _isForcedUp;
		private float _leftRight;

		public float TurnSpeed => _turnSpeed;
		public float Force => _force;

		private void Awake()
		{	
			_input = new DefaultInput();
			_mover = new Mover(this);
			_rotator = new Rotator(this);
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
			_leftRight = _input.LeftRight;
		}

		private void FixedUpdate()
		{
			if (_isForcedUp) 
			{
				_mover.FixedTick();
			}
			_rotator.FixedTick(_leftRight);
		}
	}
}