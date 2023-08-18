using Scrips.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scrips.NPS
{
    public class Narrator : MonoBehaviour
    {
        [SerializeField] private CloseButton _closeButton;
        [SerializeField] private List<Variant> _variants =new List<Variant> ();

        public event Action StatrMovement;
        public event Action StopMovement;

        private void OnEnable()
        {
            _closeButton.Exit += CloseCanvas;
            StopMovement?.Invoke();
        }

        private void OnDisable()
        {
            _closeButton.Exit -= CloseCanvas;
        }

        private void CloseCanvas()
        {
            gameObject.SetActive(false);
            StatrMovement?.Invoke();
            foreach (var variant in _variants)
            {
                variant.StopAudio();
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                PlayVariant(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                PlayVariant(2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                PlayVariant(3);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CloseCanvas();
            }
        }

        private void PlayVariant(int value)
        {
            foreach (var variant in _variants)
            {
                if (variant.ID == value)
                {
                    variant.PlayAudio();
                }
            }
        }
    }
}