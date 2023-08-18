using Scrips.Hero;
using UnityEngine;

namespace Scrips.NPS
{
    public class Bot : MonoBehaviour
    {
        [SerializeField] private TriggerObserver _triggerObserver;
        [SerializeField] private Narrator _narrator;

        private void OnEnable()
        {
            _triggerObserver.TriggerEnter += StartDialogue;
        }

        private void OnDisable()
        {
            _triggerObserver.TriggerExit -= StartDialogue;
        }

        private void StartDialogue(Collider collider)
        {
            if(collider.TryGetComponent(out HeroMove heroMove)) 
            {
                heroMove.transform.LookAt(transform.position);
                transform.LookAt(heroMove.transform.position);
                _narrator.gameObject.SetActive(true);
            }
        }
    }
}