namespace PizzaParlourForDSD601.Models
{
    public class Meatlovers : Pizza
    {
        public Meatlovers()
        {
            PizzaName = "The Mighty Meatlovers the Eskimo";
            Image = "images/meatloverspizza.jpg";
            Description = "This Pizza will love your meat AND seriously mess you up. There's so much meat on here that even the Mad Butcher had to stop making radio commercials.";
            IsGlutenFree = false;
            IsVegetarian = false;

            //items for PizzaIngredients List
            PizzaIngredients.Add("Cheese");
            PizzaIngredients.Add("Rasher Bacon");
            PizzaIngredients.Add("Pepperoni");
            PizzaIngredients.Add("Ham");
            PizzaIngredients.Add("Shredded Beef");

            //items for PizzaSizesAndPrices List
            PizzaSizesAndPrices.Add("Small - $9.50");
            PizzaSizesAndPrices.Add("Medium - $14.50");
            PizzaSizesAndPrices.Add("Large - $16.75");

            PizzaChef("Christopher Moltisanti");

        }

        //override the virtual method in the base class 
        public override void PizzaChef(string pizzaChef)
        {
            PizzaChefName = pizzaChef;
        }
    }
}
