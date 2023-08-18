using Scrips.NPS;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scrips.UI
{
    public abstract class VariantButtonClic : MonoBehaviour
    {
        [SerializeField] protected Button _button;

        public Action OptionSelected;
        public Action StopAnimation;

        private void OnEnable()
        {
            _button.onClick.AddListener(ActivateDialog);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(ActivateDialog);
        }

        private void ActivateDialog()
        {
            OptionSelected?.Invoke();
        }

        public void Stop()
        {
            StopAnimation?.Invoke();
        }
    }
}