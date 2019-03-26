using System;

namespace InternshipTest
{
    public class Knowledge
    {
        public Knowledge(int level)
        {
            if (level < 0 || level > 100)
            {
                throw new ArgumentException("level should be in range from 0 to 100");
            }
            this.Level = level;
        }

        public int Level { get; }
    }
}
