using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonPRNG.TinyMT;

namespace Gen6RNG
{
    static class Generator
    {
        // https://github.com/wwwwwwzx/3DSRNGTool/blob/master/3DSRNGTool/Gen6/TinyTimeline.cs

        public static int GetInterval_NPC(ref this (uint S0, uint S1, uint S2, uint S3) state)
            => 542 - (int) ((state.GetRand()* 180ul) >> 32) * 2;

        public static int GetInterval_Pokemon(ref this (uint S0, uint S1, uint S2, uint S3) state)
            => (int)((state.GetRand() * 240ul) >> 32) + 250;

        public static (ushort TID, ushort SID) GetID(ref this (uint S0, uint S1, uint S2, uint S3) state)
        {
            uint rand = state.GetRand();
            return ((ushort)(rand & 0x0000FFFF), (ushort)((rand & 0xFFFF0000) >> 16));
        }
    }
}
