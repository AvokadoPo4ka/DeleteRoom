using Exiled.API.Features;
using Exiled;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;

namespace DeleteRoom
{
    class Plugin : Plugin<Config>
    {
        public override string Prefix => "DelRoom";
        public override string Name => "DeleteRoomByRABB1T";
        public override string Author => "RABB1T#3072";
        public EventHandler EventHandlers { get; private set; }
        public static Plugin plugin;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStart;
            Log.Debug("Im ready!");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStart;
            base.OnDisabled();
        }
        private void OnRoundStart()
        {
            DeleteRoom();
        }

        private void DeleteRoom()
        {
            if (Config.Destroy330 == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.Lcz330).gameObject);
            }
            if (Config.DestroyTR == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.HczTestRoom).gameObject);
            }
            if (Config.DestroyShelter == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.EzShelter).gameObject);
            }
            if (Config.DestroyPc == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCafe));
            }
            if (Config.DestroyPD == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.Pocket));
            }
            if (Config.DestroyLCZArmory == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.LczArmory));
            }
            if (Config.DontTurnItOn == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.Lcz914));
            }
            if (Config.DestroyGateA == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.EzGateA));
            }
            if (Config.DestroyGateB == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.EzGateB));
            }
            if(Config.DeleteWarhead == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.HczNuke));
            }
            if (Config.DeleteToilets == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.LczToilets));
            }
            if (Config.DeleteAllLcz == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.LczToilets));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczTCross));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczStraight));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczPlants));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczGlassBox));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCurve));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCrossing));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczClassDSpawn));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCheckpointB));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCheckpointA));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczCafe));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczArmory));
                MonoBehaviour.Destroy(Room.Get(RoomType.LczAirlock));
                MonoBehaviour.Destroy(Room.Get(RoomType.Lcz914));
                MonoBehaviour.Destroy(Room.Get(RoomType.Lcz330));
                MonoBehaviour.Destroy(Room.Get(RoomType.Lcz173));
            }
            if (Config.DeleteAllHcz == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.Hcz049));
                MonoBehaviour.Destroy(Room.Get(RoomType.Hcz079));
                MonoBehaviour.Destroy(Room.Get(RoomType.Hcz096));
                MonoBehaviour.Destroy(Room.Get(RoomType.Hcz106));
                MonoBehaviour.Destroy(Room.Get(RoomType.Hcz939));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczArmory));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczCrossing));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczCurve));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczElevatorA));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczElevatorB));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczEzCheckpointA));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczEzCheckpointB));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczHid));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczNuke));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczServers));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczStraight));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczTCross));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczTesla));
                MonoBehaviour.Destroy(Room.Get(RoomType.HczTestRoom));
            }
            if (Config.DeleteAllEz == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.EzCafeteria));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzCheckpointHallway));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzCollapsedTunnel));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzConference));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzCrossing));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzCurve));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzDownstairsPcs));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzGateA));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzGateB));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzIntercom));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzPcs));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzShelter));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzStraight));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzTCross));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzUpstairsPcs));
                MonoBehaviour.Destroy(Room.Get(RoomType.EzVent));
            }
            if (Config.DeleteSurface == true)
            {
                MonoBehaviour.Destroy(Room.Get(RoomType.Surface));
                Log.Debug("Haha, u lost surface!");
            }
            // Uh, I think u delete all rooms
        }
    }
}
