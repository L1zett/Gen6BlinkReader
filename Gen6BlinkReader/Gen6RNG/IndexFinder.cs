using PokemonPRNG.TinyMT;

namespace Gen6RNG
{
    class IndexFinder
    {
        public static bool TryGetIndex(uint initSeed, uint minIndex, uint maxIndex, int[] intervals, out uint result)
        {
            var seed = initSeed.TinyMT();
            seed.Advance(minIndex);
            uint index = minIndex;

            while (index <= maxIndex)
            {
                var interval = seed.GetInterval_Pokemon();
                index++;

                if ((intervals[0] + 5) < interval || interval < (intervals[0] - 5))
                    continue;

                else
                {
                    var _seed = seed;
                    int i;
                    for (i = 1; i < intervals.Length; i++)
                    {
                        var _interval = _seed.GetInterval_Pokemon();
                        if ((intervals[i] + 5) < _interval || _interval < (intervals[i] - 5))
                            break;
                    }
                    if (i == intervals.Length)
                    {
                        result = index; // 最初に一致したindexを返す
                        return true;
                    }
                }
            }
            result = 0;
            return false;
        }
    }
}
