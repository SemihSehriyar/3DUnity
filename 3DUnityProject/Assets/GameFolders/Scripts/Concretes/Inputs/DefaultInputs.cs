using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityProject.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;
        public bool IsForcedUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => IsForcedUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();
            _input.Enable();
        }
    }
}