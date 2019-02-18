﻿// © 2018, SKStudios LLC. All Rights Reserved.
// 
// The software, artwork and data, both as individual files and as a complete software package known as 'PortalKit Pro', 
// without regard to source or channel of acquisition, are bound by the terms and conditions set forth in the Unity Asset 
// Store license agreement in addition to the following terms;
// 
// One license per seat is required for Companies, teams, studios or collaborations using PortalKit Pro that have over 
// 10 members or that make more than $50,000 USD per year. 
// 
// Addendum;
// If PortalKitPro constitutes a major portion of your game's mechanics, please consider crediting the software and/or SKStudios.
// You are in no way obligated to do so, but it would be sincerely appreciated.

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SKStudios.Portals.Demos {
    public class AssetLink : MonoBehaviour, IPointerClickHandler {
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            if (pointerEventData.button == PointerEventData.InputButton.Left)
                Application.OpenURL("https://www.assetstore.unity3d.com/en/?stay#!/content/81638");
        }

        private void Start()
        {
            GetComponent<Button>().interactable = true;
        }
    }
}