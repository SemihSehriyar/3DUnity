using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace UnityProject.Controllers 
{
    public class WallController : MonoBehaviour
    {
		private void OnCollisionEnter(Collision other)
		{
			PlayerController player = other.collider.GetComponent<PlayerController>();
			if (player != null) 
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}	
	}
}