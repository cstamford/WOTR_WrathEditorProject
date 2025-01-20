using Kingmaker.View;
using Kingmaker.View.Spawners;
using System;
using UnityEngine;

namespace Kingmaker.AreaLogic.Cutscenes.Commands.Timeline {

public class DirectorAdapter {
    public object BoundUnits /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.UnitBinding[] */;
    public object BoundTracks /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.TrackBinding[] */;
    public global::Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.DirectorCameraLink CameraLink /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.DirectorCameraLink */;

    public class UnitBinding {
        public string Name /* System.String */;
        public object PreviewPrefab /* Kingmaker.ResourceLinks.UnitViewLink */;
        public global::Kingmaker.View.Spawners.UnitSpawnerBase DefaultSpawner /* Kingmaker.View.Spawners.UnitSpawnerBase */;
    }

    public enum BoundTrackType {
        Animation = 0,
        Position = 1,
        Bark = 2,
    }

    public class TrackBinding {
        public string TrackName /* System.String */;
        public string UnitName /* System.String */;
        public global::Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.DirectorAdapter.BoundTrackType Type /* Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.BoundTrackType */;
    }

}

}

