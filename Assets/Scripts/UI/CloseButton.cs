using Scrips.NPS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scrips.UI
{
    public class CloseButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public Action Exit;

        private void OnEnable()
        {
            _button.onClick.AddListener(ButtonClicExit);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(ButtonClicExit);
        }

        private void ButtonClicExit()
        {
            Exit?.Invoke();
        }
    }
}