namespace PizzaParlourForDSD601.Models
{
    public class Vegetarian : Pizza
    {
        public Vegetarian()
        {
            PizzaName = "Terrible Pizza Choice AKA Vegetarian";
            Image = "images/vegetarianpizza.jpg";
            Description = "This pizza seriously sucks! DO NOT BUY!";
            IsGlutenFree = true;
            IsVegetarian = true;

            //items for PizzaIngredients List
            PizzaIngredients.Add("Vegan Cheese");
            PizzaIngredients.Add("Spinach");
            PizzaIngredients.Add("Olives");
            PizzaIngredients.Add("Capsicum");
            PizzaIngredients.Add("Seasonal Mushrooms");

            PizzaSizesAndPrices.Add("Small - $7.00");
            PizzaSizesAndPrices.Add("Medium - $9.00");
            PizzaSizesAndPrices.Add("Large - $10.25");

            PizzaChef("Fernando Tatis Jr.");
            
            
        }
        
        public override void PizzaChef(string pizzaChef)
        {
            PizzaChefName = pizzaChef; 
        }
    }
}
