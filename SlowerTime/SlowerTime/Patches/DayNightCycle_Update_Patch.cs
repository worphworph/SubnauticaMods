using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SlowerTime.Patches
{
    [HarmonyPatch(typeof(DayNightCycle))]
    [HarmonyPatch("Update")]
    class DayNightCycle_Update_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(1f))
                {
                    yield return new CodeInstruction(OpCodes.Ldc_R4, STSettings.Instance.DayNightCycleMultiplier);
                    continue;
                }

                yield return instruction;
            }
        }
    }
}