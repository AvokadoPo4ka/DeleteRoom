using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Linq;
using UnityEngine;

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
                foreach (Room LCZ in Room.List.Where(x => x.Zone == ZoneType.LightContainment))
                    MonoBehaviour.Destroy(LCZ);
            }
            if (Config.DeleteAllHcz == true)
            {
                foreach (Room HCZ in Room.List.Where(x => x.Zone == ZoneType.HeavyContainment))
                    MonoBehaviour.Destroy(HCZ);
            }
            if (Config.DeleteAllEz == true)
            {
                foreach (Room EZ in Room.List.Where(x => x.Zone == ZoneType.LightContainment))
                    MonoBehaviour.Destroy(EZ);
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
