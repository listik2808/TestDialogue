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
    }
}