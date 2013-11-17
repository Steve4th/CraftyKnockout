namespace CraftyKnockoutMvc.Models
{
    using System.Collections.Generic;

    public class HallOfFameModel
    {
        private readonly IList<FamousCoder> famousCoderCollection;

        public HallOfFameModel()
        {
            famousCoderCollection = new List<FamousCoder>();
        }

        public IList<FamousCoder> FamousCoders
        {
            get
            {
                return famousCoderCollection;
            }
        }
    }
}