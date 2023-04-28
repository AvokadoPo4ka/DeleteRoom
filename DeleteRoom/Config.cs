using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteRoom
{
    class Config : IConfig
    {
        [Description("Should ploogin work?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug?")]
        public bool Debug { get; set; } = false;
        [Description("Do u need to delete candies?(Dont do it pls)")]
        public bool Destroy330 { get; set; } = true;
        [Description("Ploogin want to delete OLD SCP939's spawn. Allow?")]
        public bool DestroyTR { get; set; } = false;
        [Description("Is ploogin need to destroy shit, like shelter?")]
        public bool DestroyShelter { get; set; } = false;
        [Description("Should ploogin delete PC15?")]
        public bool DestroyPc { get; set; } = false;
        [Description("Delete SCP106's PD?(Turn it to 'true' if u have custom scp106)")]
        public bool DestroyPD { get; set; } = false;
        [Description("RABB1T#3072 want to delete LCZ Armory. Allow?")]
        public bool DestroyLCZArmory { get; set; } = false;
        [Description("Oh shit, my ploogin is uncontrolled. IT WANT TO DELETE SCP914. DO NOT TURN IT TO TRUE, PLS!!!!!!!!!")]
        public bool DontTurnItOn { get; set; } = false;
        [Description("Polish cow now delete GateA.")]
        public bool DestroyGateA { get; set; } = false;
        [Description("SpongeBob coop with Polish cow. Now he delete ur GateB")]
        public bool DestroyGateB { get; set; } = false;
        [Description("Bruh, me, RABB1T#3072 make this ploogin to delete some rooms. Originaly this ploogin made for my MER map. 'Cause this u can see some rooms, what fully killed game")]
        public bool DeleteWarhead { get; set; } = false;
        [Description("Music from GTA4. I don't wallow u too poop")]
        public bool DeleteToilets { get; set; } = false;
        [Description("Bruh, don't turn it on. I made this thing ONLY for MER's user. Delete some LCZ rooms. If u have custom MER map = use it")]
        public bool DeleteAllLcz { get; set; } = false;
        [Description("Bruh, don't turn it on. I made this thing ONLY for MER's user. Delete some HCZ rooms. If u have custom MER map = use it")]
        public bool DeleteAllHcz { get; set; } = false;
        [Description("Bruh, don't turn it on. I made this thing ONLY for MER's user. Delete some EZ rooms. If u have custom MER map = use it")]
        public bool DeleteAllEz { get; set; } = false;
        [Description("I can understand deleting some CZ and EZ, but DELETE SURFACE???? Are u in ur mind? Ok, use it if u have custom surface. ONLY FOR CUSTOM SURFACE!")]
        public bool DeleteSurface { get; set; } = false;
    }
}
