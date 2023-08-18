using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scrips.Hero
{
    public class HeroAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private readonly string Walk = "Walk";
        private readonly string Idle = "Idle";

        private bool _isSelect = false;

        public void Move()
        {
            if(_isSelect == false)
            {
                _animator.SetTrigger(Walk);
                _isSelect = true;
            }
        }

        public void Stay()
        {
            if(_isSelect)
            {
                _animator.SetTrigger(Idle);
                _isSelect = false;
            }
        }
    }
}