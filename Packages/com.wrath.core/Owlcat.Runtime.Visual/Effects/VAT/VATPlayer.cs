using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.Effects.VAT {

public class VATPlayer : MonoBehaviour {
    [SerializeField] public VATPlayer.SettingsEntry m_HoudiniSettings /* Owlcat.Runtime.Visual.Effects.VAT.SettingsEntry */;
    public float Speed /* System.Single */;
    public bool IsLooped /* System.Boolean */;
    public float Delay /* System.Single */;

    public class SettingsEntry {
        public float _doubleTex /* System.Single */;
        public float _height /* System.Single */;
        public float _normData /* System.Single */;
        public float _numOfFrames /* System.Single */;
        public float _packNorm /* System.Single */;
        public float _packPscale /* System.Single */;
        public float _padPowTwo /* System.Single */;
        public float _paddedSizeX /* System.Single */;
        public float _paddedSizeY /* System.Single */;
        public float _pivMax /* System.Single */;
        public float _pivMin /* System.Single */;
        public float _posMax /* System.Single */;
        public float _posMin /* System.Single */;
        public float _scaleMax /* System.Single */;
        public float _scaleMin /* System.Single */;
        public float _speed /* System.Single */;
        public float _textureSizeX /* System.Single */;
        public float _textureSizeY /* System.Single */;
        public float _width /* System.Single */;
    }

}

}

