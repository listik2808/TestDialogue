using Scrips.Hero;
using Scrips.NPS;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : MonoBehaviour
{
    [SerializeField] private HeroMove _heroMove;
    [SerializeField] private List<Narrator> _narrator;

    private void OnEnable()
    {
        foreach(var narrator in _narrator)
        {
            narrator.StatrMovement += StartMove;
            narrator.StopMovement += StopMove;
        }
    }

    private void OnDisable()
    {
        foreach (var narrator in _narrator)
        {
            narrator.StatrMovement -= StartMove;
            narrator.StopMovement -= StopMove;
        }
    }

    private void StartMove()
    {
        _heroMove.enabled = true;
    }

    private void StopMove()
    {
        _heroMove.enabled = false;
        _heroMove.HeroAnimator.Stay();
    }
}
