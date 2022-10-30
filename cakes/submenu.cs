namespace cakes
{
    internal class submenu
    {
        public string desc;
        public int cost;

        public submenu(string desc, int cost)
        {
            this.desc = desc;
            this.cost = cost;
        }
        public void Feautres()
        {
            Console.WriteLine(desc + " - " + cost);
        }
    }
}
