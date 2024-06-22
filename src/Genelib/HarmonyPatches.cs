using System.Reflection;
using HarmonyLib;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace Genelib {
    public class HarmonyPatches {
        private static Harmony harmony = new Harmony("sekelsta.genelib");

        public static void Patch() {
            // This turned out to not be necessary, but the comment is kept as an example of how to do harmony patching
            /*
            harmony.Patch(
                typeof(EntityShapeRenderer).GetMethod("loadModelMatrix", BindingFlags.Instance | BindingFlags.Public),
                postfix: new HarmonyMethod(typeof(HarmonyPatches).GetMethod("loadModelMatrix_Postfix", BindingFlags.Static | BindingFlags.Public)) 
            );*/
        }
/*
        public static void loadModelMatrix_Postfix(EntityShapeRenderer __instance, Entity entity) {
            matstring = "";
            for (int i = 0; i < __instance.ModelMat.Length; ++i) {
                matstring += __instance.ModelMat[i] + " ";
            }
            GeneticsModSystem.ClientAPI.Logger.Notification("Model matrix for " + entity.Code + ": " + matstring);
        }*/
    }
}
