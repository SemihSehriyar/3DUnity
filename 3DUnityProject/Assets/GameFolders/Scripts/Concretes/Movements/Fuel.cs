using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityProject.Movements 
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float _maxFuel = 100f;
        [SerializeField] private float _currentFuel;
		[SerializeField] private ParticleSystem _particle;

		public bool IsEmpty => _currentFuel < 1f;

		public void Awake()
		{
			_currentFuel = _maxFuel;
		}

		public void FuelIncrease(float increase) 
		{
			_currentFuel += increase;
			_currentFuel = Mathf.Min(_currentFuel, _maxFuel);

			if (_particle.isPlaying) 
			{
				_particle.Stop();
			}
		}

		public void FuelDecrease(float decrease)
		{ 
			_currentFuel -= decrease;
			_currentFuel = Mathf.Max(_currentFuel, 0f);

			if(_particle.isStopped) 
			{
				_particle.Play();
			}
		}
	}
}