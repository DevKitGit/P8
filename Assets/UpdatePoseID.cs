using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Utilities;
using TMPro;
using UnityEngine;

public class UpdatePoseID : MonoBehaviour
{
    [SerializeField] private GestureRecorderEvents gre;
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        gre.OnGestureSelected += UpdateText;
    }

    private void OnDisable()
    {
        gre.OnGestureSelected -= UpdateText;
    }

    private void UpdateText(object obj)
    {
        //text.SetText($"Tegn {gre._poseIndex+1} ud af {gre.NumberOfPoses}");
        text.SetText($"{gre._poseIndex+1} / {gre.NumberOfPoses}: {gre.CurrentGesture.Name.ToString().Replace("Nummer","Nr. ")}");
    }
}
