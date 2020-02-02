namespace Product
{
    public class Fashion
    {
        string _name;
        string _size;
        string _price;
        string _color;
        public Fashion(string name,string size,string price,string color)
        {
            _name = name;
            _size = size;
            _price = price;
            _color = color;
        }
        public override string ToString()
        {
            return $"Name: {_name}\nSize: {_size}\nPrice: {_price}\nColor: {_color}";
        }
    }
}