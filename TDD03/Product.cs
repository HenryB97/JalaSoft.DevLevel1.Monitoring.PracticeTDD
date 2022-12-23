namespace TDD03
{
    public class Product
    {
        public Product(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public bool CanBeSold = true;

        public void UpdateProduct()
        {
            if (this.Quality > 50 && this.Name != "Sulfuras" || (this.Name == "Sulfuras" && this.Quality != 80))
            {
                throw new Exception("Invalid Data");
            }

            switch (this.Name)
            {
                case "Aged Brie":
                    this.SellIn--;
                    if (this.Quality < 50) {
                        this.Quality++;
                    }
                    else
                    {
                        this.Quality = 50;
                    }
                    this.SellIn--;
                    break;
                case "Sulfuras":
                    this.CanBeSold = false;
                    break;
                case "Backstage passes":
                    this.SellIn--;
                    if (this.SellIn < 0)
                    {
                        this.Quality = 0;
                    } else
                    {
                        if (this.SellIn < 5)
                        {
                            this.Quality += 3;
                        }
                        else if (this.SellIn < 10)
                        {
                            this.Quality += 2;
                        } else
                        {
                            this.Quality++;
                        }
                    }
                    break;
                case "Conjured":
                    if(this.Quality > 2)
                    {
                        this.Quality -= 2;
                    } else
                    {
                        this.Quality = 0;
                    }
                    this.SellIn--;
                    break;
                default:
                    if (SellIn < 0 && Quality > 2)
                    {
                        this.Quality -= 2;
                    } else if (SellIn < 0 && this.Quality == 1)
                    {
                        this.Quality = 0;
                    } else if (Quality > 0 && Quality < 50 && SellIn > 0)
                    {
                        this.SellIn--;
                        this.Quality--;
                    }
                    break;
            }

            
        }
    }
}