using MelonLoader;
using UnityEngine;

namespace ContainerTweaks
{
    public class Implementation : MelonMod
    {
        [Obsolete]
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}