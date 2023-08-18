using System;
using System.Collections;
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
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private int _id;
        private Coroutine _coroutine;

        public int ID => _id;

        private void OnEnable()
        {
            _variantButtonClic.OptionSelected += PlayAudio;
        }

        private void OnDisable()
        {
            _variantButtonClic.OptionSelected -= PlayAudio;
        }

        private void Start ()
        {
            _text.text = TextQuestion;
        }

        public void PlayAudio()
        {
            float timesound = _audioClip.length;
            Debug.Log(timesound);
            if(_coroutine != null)
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
            _coroutine = StartCoroutine(TrackLength(timesound));
        }

        public void StopAudio()
        {
            _audioSource.Stop();
        }

        private IEnumerator TrackLength(float value)
        {
            _audioSource.PlayOneShot(_audioClip);
            while (value > 0.3f)
            {
                value-=Time.deltaTime;
                Debug.Log(value);
                yield return null;
            }
            _variantButtonClic.Stop();
        }
    }
}