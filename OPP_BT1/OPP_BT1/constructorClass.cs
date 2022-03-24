namespace OPP_BT1
{
    internal class constructorClass
    {
        private string name;
        private int x, y;
        public constructorClass()
        {
            this.name = "catersian";
            this.x = 0;
            this.y = 0;

        }
        public constructorClass(string coordinate_name, int x_value ,int y_value)
        {
            this.name = coordinate_name;
            this.x = x_value;
            this.y = y_value;
        }
        public void setName(string condinate_name)
        {
            this.name=condinate_name;
        }
        public void setX(int x_value)
        {
            this.x = x_value;
        }

        public void setY(int y_value)
        {
            this.y=y_value;
        }

        public string getName()
        {
            return this.name;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
        public override string ToString()
        {
            return ($"{ this.name } ({ this.x},{ this.y})");
        }
    }
}
