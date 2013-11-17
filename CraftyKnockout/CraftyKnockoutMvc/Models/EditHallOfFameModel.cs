namespace CraftyKnockoutMvc.Models
{
    using System.Collections.Generic;

    public class EditHallOfFameModel
    {
        private readonly IList<FamousCoder> famousCoderCollection;

        public EditHallOfFameModel()
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