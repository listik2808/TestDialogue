using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scrips.UI
{
    public class VariantButtonClic : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public Action WasСhosen;

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
            WasСhosen?.Invoke();
        }
    }
}