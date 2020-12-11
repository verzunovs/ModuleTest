namespace HomeWorkForModuleTest.Helper
{
    using System.Collections;

    public class AnimalComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Animal;
            var y = second as Animal;
            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
