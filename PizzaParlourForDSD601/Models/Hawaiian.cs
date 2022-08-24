namespace PizzaParlourForDSD601.Models
{
    public class Hawaiian : Pizza
    {

        public Hawaiian()
        {
            PizzaName = "The Flyin Hawaiin";
            Image = "images/hawaiianpizza.jpg";
            Description = "This Hawaiian that we're supplyin' is gonna seriously mess you up man! Made by only the most surfingest pizza chefs that also surf in Hawaii, this Pizza is going to give you curly black hair.";
            IsGlutenFree = true;
            IsVegetarian = false;


            //items for PizzaIngredients List
            PizzaIngredients.Add("Cheese");
            PizzaIngredients.Add("Pineapple");
            PizzaIngredients.Add("Ham");

            //items for PizzaSizesAndPrices List
            PizzaSizesAndPrices.Add("Small - $7.50");
            PizzaSizesAndPrices.Add("Medium - $10.00");
            PizzaSizesAndPrices.Add("Large - $11.25");




            PizzaChef("Bartolo Colon");



    }
        public override void PizzaChef(string pizzaChef)
        {
            PizzaChefName = pizzaChef;
        }

    }
}
