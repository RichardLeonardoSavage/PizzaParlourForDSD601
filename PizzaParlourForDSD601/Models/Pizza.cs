namespace PizzaParlourForDSD601.Models
{

    //create interface for this class
    public class Pizza
    {
        //Consider putting Id property here during code review
        public string PizzaName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        //these lists need to be instantiated
        public List<string> PizzaIngredients { get; set; }
        public List<string> PizzaSizesAndPrices { get; set; }

        //this is for the selectlist
        //public List<PizzaSelection> PizzaFlavourSelection { get; set; }

        //method to instantiate lists
        public Pizza()
        {

            //consider aggregate classes when reviewing code

            PizzaIngredients = new List<string>();
            PizzaSizesAndPrices = new List<string>();
        }

        //add virtual method here
    }
}
