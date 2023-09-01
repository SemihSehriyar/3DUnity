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
		private Fuel _fuel;

		private bool _isForcedUp;
		private float _leftRight;

		public float TurnSpeed => _turnSpeed;
		public float Force => _force;

		private void Awake()
		{	
			_input = new DefaultInput();
			_mover = new Mover(this);
			_rotator = new Rotator(this);
			_fuel = GetComponent<Fuel>();
		}

		private void Update()
		{
			if (_input.IsForcedUp && !_fuel.IsEmpty) 
			{
				_isForcedUp = true;
			}
			else 
			{
				_isForcedUp = false;
				_fuel.FuelIncrease(0.1f);
			}
			_leftRight = _input.LeftRight;
		}

		private void FixedUpdate()
		{
			if (_isForcedUp) 
			{
				_mover.FixedTick();
				_fuel.FuelDecrease(0.5f);

			}
			_rotator.FixedTick(_leftRight);
		}
	}
}