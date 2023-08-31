using System.Collections;
using System.Collections.Generic;
using UnityProject.Controllers;
using UnityEngine;

namespace UnityProject.Movements 
{
	public class Mover
	{
		private PlayerController _playerController;
		private Rigidbody _rigidbody;

		public Mover(PlayerController playerController)
		{
			_playerController = playerController;
			_rigidbody = playerController.GetComponent<Rigidbody>();
		}

		public void FixedTick() 
		{
			_rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
		}
	}
}