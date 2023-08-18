using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scrips.UI
{
    public class Variant : MonoBehaviour
    {
        [SerializeField] private VariantButtonClic _variantButtonClic;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private string TextQuestion;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private int _id;

        public int ID => _id;

        private void OnEnable()
        {
            _variantButtonClic.Was—hosen += PlayAudio;
        }

        private void OnDisable()
        {
            _variantButtonClic.Was—hosen -= PlayAudio;
        }

        private void Start ()
        {
            _text.text = TextQuestion;
        }

        public void PlayAudio()
        {
            _audioSource.Play();
        }

        public void StopAudio()
        {
            _audioSource.Stop();
        }
    }
}