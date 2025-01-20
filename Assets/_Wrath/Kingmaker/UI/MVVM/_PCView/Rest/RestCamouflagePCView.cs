using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCamouflagePCView : global::Kingmaker.UI.MVVM._PCView.Rest.RestCamouflageBaseView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestShiftPCView m_PrimaryShiftView /* Kingmaker.UI.MVVM._PCView.Rest.RestShiftPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestShiftPCView m_SecondaryShiftView /* Kingmaker.UI.MVVM._PCView.Rest.RestShiftPCView */;
    [SerializeField] public global::UnityEngine.UI.Button m_CloseButton /* UnityEngine.UI.Button */;
}

}

