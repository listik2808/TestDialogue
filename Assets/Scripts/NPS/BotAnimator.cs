using Scrips.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Scrips.NPS
{
    public class BotAnimator : MonoBehaviour
    {
        public const string Idle = "Idle";
        public const string Waving = "Waving";
        public const string Dance = "Dance";
        public const string Talking = "Talking";

        [SerializeField] private Animator _animator;
        [SerializeField] private VariantButtonClicOne _variantOne;
        [SerializeField] private VariantButtonClicTwo _variantTwo;
        [SerializeField] private VariantButtonClicThree _variantThree;

        private void OnEnable()
        {
            _variantOne.OptionSelected += AnimationVariantOne;
            _variantTwo.OptionSelected += AnimationVariantTwo;
            _variantThree.OptionSelected += AnimationVariantThree;
            _variantOne.StopAnimation += AnimationIdle;
            _variantTwo.StopAnimation += AnimationIdle;
            _variantThree.StopAnimation += AnimationIdle;
        }

        private void OnDisable()
        {
            _variantOne.OptionSelected -= AnimationVariantOne;
            _variantTwo.OptionSelected -= AnimationVariantTwo;
            _variantThree.OptionSelected -= AnimationVariantThree;
            _variantOne.StopAnimation -= AnimationIdle;
            _variantTwo.StopAnimation -= AnimationIdle;
            _variantThree.StopAnimation -= AnimationIdle;
        }

        public void AnimationVariantOne()
        {
            _animator.SetTrigger(Waving);
        }

        public void AnimationVariantTwo()
        {
            _animator.SetTrigger(Dance);
        }

        public void AnimationVariantThree()
        {
            _animator.SetTrigger(Talking);
        }

        public void AnimationIdle()
        {
            _animator.SetTrigger(Idle);
        }
    }
}